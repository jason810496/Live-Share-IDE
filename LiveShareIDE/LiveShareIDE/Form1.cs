using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// for socket 
using System.Net.Sockets;
using System.Net;

// material btn for message tag \
using MaterialSkin;
using MaterialSkin.Controls;


namespace LiveShareIDE
{
    public partial class Form1 : Form
    {
        public string folderName;
        public string fileName;
        public string currentDirectory = "\\";
        public int cmd_line_cnt = 0;

        // socket thing 
        private TcpClient _client;
        byte[] _buffer = new byte[4096];



        private string localIp;
        private string remoteIp;
        private string localPort;
        private string remotePort;

        private string room_id;
        private string user_name;
        private int wordBreak = 27;
        private int fontHt = 18;

        //  drag form 
        public Point mousePos;
        // recv sep
        private string sep = "^=][=^";

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
                    
            }
        
            return "127.0.0.1";
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private string Base64Decode(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch(Exception ex) { }

            return base64EncodedData;
        }




        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = true;
            DirTree.ImageList = imageList1;

            consoleControl1.StartProcess("powershell","");
            CodeEditor.Text = "\\* open folder to start coding*\\";

            // setup socket 
            //_client = new TcpClient();


            // init ip & port 
            localIp = "127.0.0.1";
            localPort = "100";

            remoteIp = "127.0.0.1";
            remotePort = "52023";
        }

        /* open file event */
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // clear last dir infor 
                DirTree.Nodes.Clear();
                var f = openFileDialog1.FileNames;

                // add files to TreeView
                foreach (string path in f )
                {
                    FileInfo fi = new FileInfo(path);
                    TreeNode node = DirTree.Nodes.Add(fi.Name);
                    node.Tag = fi;
                }
            }
        }

        /* open folder event */
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // clear last dir infor 
                DirTree.Nodes.Clear();
                folderName = folderBrowserDialog1.SelectedPath;
                // update directory infor
                currentDirectory = folderName;
                currentDirectory = folderName.Substring(folderName.LastIndexOf('\\')+1);
                DirText.Text = (currentDirectory.Length <= 10 ? currentDirectory : currentDirectory.Substring(0, 10) + "...");

                // add folder to TreeView
                foreach ( string path in Directory.GetDirectories(folderName) )
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    TreeNode node = DirTree.Nodes.Add(dir.Name , dir.Name , 0 );
                    node.Tag = dir;
                }

                // add files to TreeView
                foreach (string path in Directory.GetFiles(folderName))
                {
                    FileInfo fi = new FileInfo(path);
                    TreeNode node = DirTree.Nodes.Add(fi.Name, fi.Name, 1);
                    node.Tag = fi;
                }
            }
        }

        private void DirTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode TopNode = e.Node;
            if (TopNode.Tag == null)
            {

            }
            else if(TopNode.Tag.GetType() == typeof(DirectoryInfo) )
            {
                TopNode.Nodes.Clear();

                // add files & folder to subnodes 
                
                foreach (string path in Directory.GetDirectories( ((DirectoryInfo)TopNode.Tag).FullName) )
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    TreeNode node = TopNode.Nodes.Add(dir.Name, dir.Name, 0);
                    node.Tag = dir;
                }

                // add files to TreeView
                foreach (string path in Directory.GetFiles(((DirectoryInfo)TopNode.Tag).FullName) ) 
                {
                    FileInfo fi = new FileInfo(path);
                    TreeNode node = TopNode.Nodes.Add(fi.Name, fi.Name, 1);
                    node.Tag = fi;
                }

                TopNode.Expand();
            }
            else
            {
                // open file : 
                CodeEditor.Text = File.ReadAllText(((FileInfo)TopNode.Tag).FullName);
                OpenCode();
            }
        }

        private void OpenCode()
        {
            if (_client == null) return;
            var msg = Encoding.ASCII.GetBytes("{ \"event\":\"code\",\"room\":\"" + room_id + "\",\"user\":\"" + user_name + "\",\"content\":\"" + Base64Encode(CodeEditor.Text) + "\"}");
            _client.GetStream().Write(msg, 0, msg.Length);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            consoleControl1.StopProcess();
            consoleControl1.Dispose();
            Application.Exit();
        }

        private void MinWindowBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
        private void MessageCallback(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //Converting byte[] to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                Console.WriteLine("Recv : " + receivedMessage);
                listMessage.Items.Add("Recv :" + textMessage.Text);

                buffer = new byte[1500]; 
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallback), buffer);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.ToString());
                listMessage.Items.Add("Error :" + ex.ToString());
            }
        }
        */

        private void Server_MessageReceived(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                try
                {
                    // End the stream read
                    var bytesIn = _client.GetStream().EndRead(ar);
                    if (bytesIn > 0)
                    {
                        // Create a string from the received data. For this server 
                        // our data is in the form of a simple string, but it could be
                        // binary data or a JSON object. Payload is your choice.
                        var tmp = new byte[bytesIn];
                        Array.Copy(_buffer, 0, tmp, 0, bytesIn);
                        string str = (Encoding.ASCII.GetString(tmp));

                        bool op = str.Contains(sep);
                        Console.Write("op :" + op);

                        if ( !op ) // normal message
                        {
                            BeginInvoke((Action)(() =>
                            {
                                str = Base64Decode(str);
                                //listMessage.Items.Add(str);
                                //listMessage.SelectedIndex = listMessage.Items.Count - 1;
                                //MaterialButton btn = new MaterialButton();
                                //btn.Text = str;
                                RichTextBox msg = new RichTextBox();
                                msg.BorderStyle = BorderStyle.None;
                                msg.Text = str;
                                msg.Width = 200;
                                msg.Height = fontHt * (msg.Text.Length / wordBreak + 1);
                                msg.ScrollBars = RichTextBoxScrollBars.None;
                                msg.ReadOnly = true;

                                RichTextBox space = new RichTextBox();
                                space.Width = 100;
                                space.Height = fontHt;
                                space.BorderStyle = BorderStyle.None;
                                space.ReadOnly = true;
                                space.BackColor = Color.FromArgb(34, 50, 62);


                                flowLayoutPanel1.Controls.Add(msg);
                                flowLayoutPanel1.Controls.Add(space);
                            }));
                        }
                        else
                        {
                            BeginInvoke((Action)(() =>
                            {
                                CodeEditor.Text = Base64Decode(str.Substring(6));
                            }));
                        }
                        
                    }

                    // Clear the buffer and start listening again
                    Array.Clear(_buffer, 0, _buffer.Length);
                    _client.GetStream().BeginRead(_buffer,
                                                    0,
                                                    _buffer.Length,
                                                    Server_MessageReceived,
                                                    null);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("server error : " + ex.ToString());
                }
               
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectBtn.Visible = false;
            userTxtBox.Visible = false;
            roomTxtBox.Visible = false;
            NetworkPanel.Visible = false;
            try
            {
                //_client = new TcpClient( GetLocalIP() , 52023 );
                _client = new TcpClient( remoteIp, 52023);

                // Start reading the socket and receive any incoming messages
                _client.GetStream().BeginRead(_buffer,
                                                0,
                                                _buffer.Length,
                                                Server_MessageReceived,
                                                null);

                //var msg = Encoding.ASCII.GetBytes(textMessage.Text);

                // send join message : 
                //{"event":"join","room":room_id,"user":"name"}
                room_id = roomTxtBox.Text;
                user_name = userTxtBox.Text;
                var msg = Encoding.ASCII.GetBytes("{\"event\":\"join\",\"room\":\"" + room_id + "\",\"user\":\""+ user_name + "\"}" );
                _client.GetStream().Write(msg, 0, msg.Length);

                roomBar.Text = room_id;
            }
            catch (Exception ex)
            {
                connectBtn.Visible = true;
                userTxtBox.Visible = true;
                roomTxtBox.Visible = true;
                NetworkPanel.Visible = true;
                MessageBox.Show(ex.ToString());
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            /*
            //Convert string message to bytel]
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);
            //Sending the Encoded message
            sck.Send(sendingMessage);
            //adding to the listbox
            listMessage.Items.Add("Me:" + textMessage.Text);
            textMessage.Text = "";
            */

            // Encode the message and send it out to the server.
            //var msg = Encoding.ASCII.GetBytes(textMessage.Text);
            //_client.GetStream().Write(msg, 0, msg.Length);

            RichTextBox my_msg = new RichTextBox();
            my_msg.ReadOnly = true;
            my_msg.Anchor = AnchorStyles.Right;
            my_msg.BorderStyle = BorderStyle.None;
            my_msg.Text = textMessage.Text;
            my_msg.Width = 200;
            my_msg.Height = fontHt * (my_msg.Text.Length / wordBreak + 1);
            my_msg.ScrollBars = RichTextBoxScrollBars.None;

            RichTextBox space = new RichTextBox();
            space.Width = 100;
            space.Height = fontHt;
            space.BorderStyle = BorderStyle.None;
            space.ReadOnly = true;
            space.BackColor = Color.FromArgb(34, 50, 62);

            flowLayoutPanel1.Controls.Add(space);
            flowLayoutPanel1.Controls.Add(my_msg);
            //my_msg.Location = new Point(my_msg.Location.X + 100, my_msg.Location.Y);


            var msg = Encoding.ASCII.GetBytes("{ \"event\":\"mesg\",\"room\":\""+ room_id + "\",\"user\":\""+ user_name + "\",\"content\":\""+ Base64Encode(textMessage.Text)+"\"}");
            _client.GetStream().Write(msg, 0, msg.Length);

            // Clear the text box and set it's focus
            textMessage.Text = "";
            textMessage.Focus();
        }

        private void MaxWindowBtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mp = Control.MousePosition;
                mp.Offset(mousePos.X, mousePos.Y);
                Location = mp;   
            }
        }
    }
}
