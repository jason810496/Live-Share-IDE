# Live-Share-IDE
A Live-Share IDE written in `C#` . With directory tree , syntax high-lighting , chat room , intergerated console ... etc

## Demo video

[![Demo video](https://img.youtube.com/vi/9qjtwq9A4FM/mqdefault.jpg)](https://youtu.be/9qjtwq9A4FM)

More : testing multi-room & multi client mechanism

[![Demo video](https://img.youtube.com/vi/typO4xh4L0g/mqdefault.jpg)](https://youtu.be/typO4xh4L0g)

## ScreenShot

![LiveShareIDE Demo](https://user-images.githubusercontent.com/68415893/211127205-42403dd6-9077-413b-837f-2ff060988293.png)

## Requirement 
**server**
- `python` 3.9 up

## How to use ? 

1. run python sokcet server ( `server.py` )
2. open `LiveShareIDE.exe` and enjoy ! ✨


## Feature 
**Python Socket Server :**
- multi client
- multi room

**ChatRoom :**
- join by room_id & user_name
- multi client receiving

**DirectoryTree :** 
- nested view
- click to open file 

**CodeEditor :**
- auto line count 
- syntax highlighting
- bracket matching

**UI Design  :**
- self designed compomnent
- material style 

### Reference 

#### Client 

[Client branch](https://github.com/jason810496/Live-Share-IDE/tree/client)

#### Server 
multi-client socket server & client side written in cpp / python3 to test socket IO .

[Server branch](https://github.com/jason810496/Live-Share-IDE/tree/server)
