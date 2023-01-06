namespace LiveShareIDE
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DirText = new System.Windows.Forms.TextBox();
            this.DirTree = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MaxWindowBtn = new System.Windows.Forms.PictureBox();
            this.MinWindowBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.roomTxtBox = new System.Windows.Forms.TextBox();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.roomBar = new System.Windows.Forms.TextBox();
            this.chatBar = new System.Windows.Forms.TextBox();
            this.NetworkPanel = new System.Windows.Forms.Panel();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWindowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindowBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.NetworkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.DirText);
            this.panel1.Controls.Add(this.DirTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 838);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(3, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 19);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "EXPLORER";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DirText
            // 
            this.DirText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.DirText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirText.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DirText.Location = new System.Drawing.Point(0, 32);
            this.DirText.MaxLength = 10;
            this.DirText.Name = "DirText";
            this.DirText.ReadOnly = true;
            this.DirText.Size = new System.Drawing.Size(166, 21);
            this.DirText.TabIndex = 8;
            this.DirText.Text = "DIRECTORY";
            this.DirText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DirTree
            // 
            this.DirTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.DirTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirTree.ForeColor = System.Drawing.Color.LightGray;
            this.DirTree.Location = new System.Drawing.Point(0, 61);
            this.DirTree.Name = "DirTree";
            this.DirTree.Size = new System.Drawing.Size(166, 721);
            this.DirTree.TabIndex = 6;
            this.DirTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DirTree_NodeMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textMessage);
            this.panel3.Controls.Add(this.chatBar);
            this.panel3.Controls.Add(this.roomBar);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.listMessage);
            this.panel3.Controls.Add(this.sendBtn);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1114, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 838);
            this.panel3.TabIndex = 2;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 16;
            this.listMessage.Location = new System.Drawing.Point(0, 0);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(281, 356);
            this.listMessage.TabIndex = 4;
            this.listMessage.Visible = false;
            // 
            // sendBtn
            // 
            this.sendBtn.AutoSize = true;
            this.sendBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(264, 766);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(60, 36);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.875F, System.Drawing.FontStyle.Bold);
            this.connectBtn.Location = new System.Drawing.Point(181, 23);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(121, 55);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.consoleControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(166, 698);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 183);
            this.panel2.TabIndex = 3;
            // 
            // consoleControl1
            // 
            this.consoleControl1.IsInputEnabled = true;
            this.consoleControl1.Location = new System.Drawing.Point(0, 0);
            this.consoleControl1.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = false;
            this.consoleControl1.Size = new System.Drawing.Size(948, 183);
            this.consoleControl1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MaxWindowBtn);
            this.panel4.Controls.Add(this.MinWindowBtn);
            this.panel4.Controls.Add(this.CloseBtn);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1444, 43);
            this.panel4.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.editToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.fileFToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileFToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileFToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.openFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.openFolderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As ...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasToolStripMenuItem,
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.undoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.redoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.cutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.copyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasToolStripMenuItem
            // 
            this.pasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.pasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pasToolStripMenuItem.Name = "pasToolStripMenuItem";
            this.pasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasToolStripMenuItem.Text = "Paste";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.findToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.replaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getStartToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.showAllCommandToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // getStartToolStripMenuItem
            // 
            this.getStartToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.getStartToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getStartToolStripMenuItem.Name = "getStartToolStripMenuItem";
            this.getStartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.getStartToolStripMenuItem.Text = "Get Started";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.documentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // showAllCommandToolStripMenuItem
            // 
            this.showAllCommandToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(57)))));
            this.showAllCommandToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showAllCommandToolStripMenuItem.Name = "showAllCommandToolStripMenuItem";
            this.showAllCommandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllCommandToolStripMenuItem.Text = "Show all command";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CodeEditor);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(166, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(948, 655);
            this.panel5.TabIndex = 5;
            // 
            // CodeEditor
            // 
            this.CodeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.CodeEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.CodeEditor.AutoScrollMinSize = new System.Drawing.Size(179, 14);
            this.CodeEditor.BackBrush = null;
            this.CodeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.CodeEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.CodeEditor.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.CodeEditor.CharHeight = 14;
            this.CodeEditor.CharWidth = 8;
            this.CodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CodeEditor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CodeEditor.HighlightingRangeType = FastColoredTextBoxNS.HighlightingRangeType.AllTextRange;
            this.CodeEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.CodeEditor.IsReplaceMode = false;
            this.CodeEditor.Language = FastColoredTextBoxNS.Language.CSharp;
            this.CodeEditor.LeftBracket = '(';
            this.CodeEditor.LeftBracket2 = '{';
            this.CodeEditor.Location = new System.Drawing.Point(3, 35);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.CodeEditor.RightBracket = ')';
            this.CodeEditor.RightBracket2 = '}';
            this.CodeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(47)))), ((int)(((byte)(124)))), ((int)(((byte)(153)))));
            this.CodeEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CodeEditor.ServiceColors")));
            this.CodeEditor.ServiceLinesColor = System.Drawing.Color.White;
            this.CodeEditor.Size = new System.Drawing.Size(945, 620);
            this.CodeEditor.TabIndex = 3;
            this.CodeEditor.Text = "fastColoredTextBox1";
            this.CodeEditor.Zoom = 100;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-folder-blue.png");
            this.imageList1.Images.SetKeyName(1, "icons8-file-blue.png");
            this.imageList1.Images.SetKeyName(2, "folder_icon.png");
            this.imageList1.Images.SetKeyName(3, "file_icon.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.flowLayoutPanel1.Controls.Add(this.NetworkPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 711);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // MaxWindowBtn
            // 
            this.MaxWindowBtn.BackgroundImage = global::LiveShareIDE.Properties.Resources.max_outline;
            this.MaxWindowBtn.Image = global::LiveShareIDE.Properties.Resources.icons8_full_screen_24;
            this.MaxWindowBtn.Location = new System.Drawing.Point(1395, 4);
            this.MaxWindowBtn.Name = "MaxWindowBtn";
            this.MaxWindowBtn.Size = new System.Drawing.Size(24, 24);
            this.MaxWindowBtn.TabIndex = 3;
            this.MaxWindowBtn.TabStop = false;
            this.MaxWindowBtn.Click += new System.EventHandler(this.MaxWindowBtn_Click);
            // 
            // MinWindowBtn
            // 
            this.MinWindowBtn.BackgroundImage = global::LiveShareIDE.Properties.Resources.min_outline;
            this.MinWindowBtn.Image = global::LiveShareIDE.Properties.Resources.min_outline;
            this.MinWindowBtn.Location = new System.Drawing.Point(1372, 4);
            this.MinWindowBtn.Name = "MinWindowBtn";
            this.MinWindowBtn.Size = new System.Drawing.Size(24, 24);
            this.MinWindowBtn.TabIndex = 2;
            this.MinWindowBtn.TabStop = false;
            this.MinWindowBtn.Click += new System.EventHandler(this.MinWindowBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::LiveShareIDE.Properties.Resources.close_outline;
            this.CloseBtn.Location = new System.Drawing.Point(1418, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 24);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // roomTxtBox
            // 
            this.roomTxtBox.Location = new System.Drawing.Point(34, 57);
            this.roomTxtBox.Name = "roomTxtBox";
            this.roomTxtBox.Size = new System.Drawing.Size(121, 21);
            this.roomTxtBox.TabIndex = 6;
            this.roomTxtBox.Text = "room_id";
            this.roomTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(34, 30);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(121, 21);
            this.userTxtBox.TabIndex = 7;
            this.userTxtBox.Text = "user_name";
            this.userTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomBar
            // 
            this.roomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.roomBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomBar.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.roomBar.Location = new System.Drawing.Point(0, 19);
            this.roomBar.MaxLength = 10;
            this.roomBar.Name = "roomBar";
            this.roomBar.ReadOnly = true;
            this.roomBar.Size = new System.Drawing.Size(330, 21);
            this.roomBar.TabIndex = 10;
            this.roomBar.Text = "ROOM";
            this.roomBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chatBar
            // 
            this.chatBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.chatBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chatBar.Location = new System.Drawing.Point(0, 0);
            this.chatBar.Name = "chatBar";
            this.chatBar.ReadOnly = true;
            this.chatBar.Size = new System.Drawing.Size(330, 19);
            this.chatBar.TabIndex = 10;
            this.chatBar.Text = "CHAT";
            this.chatBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NetworkPanel
            // 
            this.NetworkPanel.Controls.Add(this.userTxtBox);
            this.NetworkPanel.Controls.Add(this.connectBtn);
            this.NetworkPanel.Controls.Add(this.roomTxtBox);
            this.NetworkPanel.Location = new System.Drawing.Point(3, 3);
            this.NetworkPanel.Name = "NetworkPanel";
            this.NetworkPanel.Size = new System.Drawing.Size(305, 108);
            this.NetworkPanel.TabIndex = 8;
            // 
            // textMessage
            // 
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMessage.Location = new System.Drawing.Point(3, 760);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(255, 47);
            this.textMessage.TabIndex = 11;
            this.textMessage.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(0, 819);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(330, 19);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "CHAT";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaxWindowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWindowBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.NetworkPanel.ResumeLayout(false);
            this.NetworkPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private FastColoredTextBoxNS.FastColoredTextBox CodeEditor;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCommandToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TreeView DirTree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox MinWindowBtn;
        private System.Windows.Forms.PictureBox MaxWindowBtn;
        private ConsoleControl.ConsoleControl consoleControl1;
        private System.Windows.Forms.TextBox DirText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox roomTxtBox;
        private System.Windows.Forms.TextBox roomBar;
        private System.Windows.Forms.TextBox chatBar;
        private System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Panel NetworkPanel;
        private System.Windows.Forms.TextBox textBox2;
    }
}

