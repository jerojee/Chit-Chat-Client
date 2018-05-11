using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using ProtoBuf;
using ChitChat.Events;


namespace ChitChatClient
{
    public partial class MainForm : Form
    {
        public static MainForm Current;
        public RichTextBox mainChatBox;
        
        public List<Chatroom> chatroomList;
        public static string nameOfChat;

        public Form RefToForm2 { get; set; }
        public Form RefToForm1 { get; set; }

        bool doneRunning = false;

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.RefToForm2.Close();
        }

        public MainForm()
        {
            InitializeComponent();
            Current = this;
            mainChatBox = richTextBox1;
            chatroomList = new List<Chatroom>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using(StreamWriter txt = new StreamWriter("Register.txt"))
            {
                txt.Write(richTextBox1.Text);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //These two lines of code, in tandem, allow the scrollbar to stay "fixed" at the bottom of the chatlog if something is entered in. It automatically scrolls downwards if not already at the bottom of the chatlog. (though as a feature this may be annoying for extended discussions)
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string message = txtMsgBox.Text + Environment.NewLine;
            this.AcceptButton = sendMessageButton; //This allows to submit text using the Enter keyboard button, without having to click "submit" button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm obj2 = new LoginForm();
            obj2.RefToForm1 = this;
            this.Visible = false;
            obj2.Show();
            this.Hide();

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            string outgoingMessage = txtMsgBox.Text;
            string chatName = nameOfChat;

            if(outgoingMessage.All(char.IsWhiteSpace))
            {
                return;
            }

            SendAMessage(outgoingMessage, nameOfChat);
            txtMsgBox.Clear();       
        }

        public void SendAMessage(string outgoingMessage, string chatName)
        {
            pbSendMessage message = new pbSendMessage
            {
                SenderName = ClientInfo.clientUsername,
                OutMessage = outgoingMessage,
                RoomName = chatName,
                Type = EventType.SEND_MESSAGE
            };


            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, message, PrefixStyle.Base128);

            this.UpdateChatBox(message.SenderName, message.OutMessage);
        }

        private void joinChatButton_Click(object sender, EventArgs e)
        {         
            JoinChatForm form = new JoinChatForm();

            string chatName = null;
            bool roomExists = false; //preset flag to check if room exists

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                chatName = form.getChatName();

                if (chatName.All(char.IsWhiteSpace))
                {
                    MessageBox.Show("Please enter a chat name.");
                    form.Close();
                    return;
                }

                var newRoom = new Chatroom()
                {
                    chatRoomName = chatName,
                    chatBox = new RichTextBox()
                };

                if (chatName != null)
                {
                    foreach (string chat in chatroomListBox.Items)
                    {
                        if (chat.ToString() == chatName)
                        {
                            MessageBox.Show("That chatroom already exists!");
                            roomExists = true;  //set flag to room exists
                            form.Close();
                            return;
                            //break;
                        }
                    }

                }
                if (roomExists == false)
                {
                    chatroomList.Add(newRoom);
                }

                form.Close();
            }
            if(form.getJoinChatName(chatName))
            {
                if (roomExists == false) 
                    chatroomListBox.Items.Add(chatName);
            }
            else
            {
                 MessageBox.Show("Error creating chatroom");
            }
        }

        private void createChatButton_Click(object sender, EventArgs e)
        {
            CreateChatForm form = new CreateChatForm();

            string chatName = null;
            bool roomExists = false; //preset flag to check if room exists
        
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                chatName = form.getChatName();

                if (chatName.All(char.IsWhiteSpace))
                {
                    MessageBox.Show("Please enter a chat name.");
                    form.Close();
                    return;
                }

                var newRoom = new Chatroom()
                {
                    chatRoomName = chatName,
                    chatBox = new RichTextBox()
                };

                if(chatName != null)
                {
                    foreach(string chat in chatroomListBox.Items)
                    {
                        if(chat.ToString() == chatName)
                        {
                            MessageBox.Show("That chatroom already exists!");
                            roomExists = true;  //set flag to room exists
                            form.Close();
                            return;
                            //break;
                        }
                    }

                }
                if (roomExists == false)
                {
                   chatroomList.Add(newRoom);
                }

                form.Close();
            }

            if (form.sendChatName(chatName))
            {
                if(roomExists == false)
                    chatroomListBox.Items.Add(chatName);
            }
            else
            {
                MessageBox.Show("Error creating chatroom");
            }
        }

        public void addChatNameToList(string chatName)
        {
            chatroomListBox.Items.Add(chatName);
        }

        public string getSelectedChatroom()
        {
            return chatroomListBox.SelectedItem.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          if(e.CloseReason == CloseReason.UserClosing)
            {
                logoff();
                doneRunning = true;
                Application.Exit();
            }
              
        }

        private void logoffButton_Click(object sender, EventArgs e)
        {
            LoginForm obj2 = new LoginForm();
            obj2.RefToForm1 = this;
            this.Visible = false;
            obj2.Show();
            this.Hide();

            logoff();
            doneRunning = true;
        
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Thread receiveMessagesThread = new Thread(new ThreadStart(StartReceivingMessages));
            receiveMessagesThread.Start();
        }

        public void logoff()
        {
            pbLogoutRequest logoutRequest = new pbLogoutRequest
            {
                Type = EventType.LOGOUT
            };

            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, logoutRequest, PrefixStyle.Base128);

            //Close client connection so it can be reset
            ClientInfo.c.stream.Close(); 
            ClientInfo.c._client.Close();
            ClientInfo.c = null;
            
        }

        public void StartReceivingMessages()
        {
            do
            {
                Console.WriteLine("waiting for some freakin' messages");

                var message = new pbReceiveMessage();

                try
                { 
                   message = Serializer.DeserializeWithLengthPrefix<pbReceiveMessage>(ClientInfo.c.stream, PrefixStyle.Base128);
                }
                 catch (IOException ioe)
                {
                    Console.WriteLine(ioe.ToString());
                    doneRunning = true;
                    return;
                }

                var chatRoom = chatroomList.Find(room => room.chatRoomName.Equals(message.RoomName));
                if (chatRoom != null)
                {
                    chatRoom.chatBoxTextLines.Add(message.SenderName + ": " + message.InMessage + Environment.NewLine);
                }

                if (message != null)
                {
                    //mainChatBox.SelectionAlignment = HorizontalAlignment.Left;
                    Console.WriteLine("Deserialized a message");
                    if ((nameOfChat != null) && (nameOfChat.Equals(message.RoomName)))
                    {
                        mainChatBox.Invoke(new UpdateChatBoxCallback(this.UpdateChatBox),
                            new object[] { message.SenderName, message.InMessage });
                    }
                }

            } while (true && !doneRunning);
        }

        public void UpdateChatBox(string sender, string message)
        {
            mainChatBox.AppendText(sender + ": " + message + Environment.NewLine);

        }

        public delegate void UpdateChatBoxCallback(string sender, string message);

        private void chatroomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //store chat room text for later reference on reopening the chatroom
            string temp = nameOfChat;
            var chatRoom = chatroomList.Find(room => room.chatRoomName.Equals(temp));
            if(chatRoom != null)
            {
                chatRoom.chatBoxTextLines = chatRoom.chatBox.Lines.ToList<string>();
            }

            //create new chat room
            var newChatRoom = chatroomList.Find(room => room.chatRoomName.Equals(getSelectedChatroom()));
            if (newChatRoom != null)
            {
                nameOfChat = newChatRoom.chatRoomName;
                mainChatBox.Hide();
                newChatRoom.chatBox = mainChatBox;
                newChatRoom.chatBox.Clear();
                mainChatBox = newChatRoom.chatBox;

                //get previous chatroom text
                for(int count = 0; count < newChatRoom.chatBoxTextLines.Count; count++)
                {
                    if (string.IsNullOrWhiteSpace(newChatRoom.chatBoxTextLines[count]))
                        continue;
                    else
                        mainChatBox.AppendText(newChatRoom.chatBoxTextLines[count] + Environment.NewLine);
                }

            
                
                mainChatBox.Show();
                              
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ClientInfo.friendsList != null)
            {
                for (int i = 0; i < ClientInfo.friendsList.Count; i++)
                    friendsListBox.Items.Add(ClientInfo.friendsList[i]);
            }
        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            AddFriendForm form = new AddFriendForm();

            string friendName = null;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                friendName = form.getFriendName();
                if (friendName != null)
                {
                    if (friendName.All(char.IsWhiteSpace))
                    {
                        MessageBox.Show("Please enter a name.");
                        form.Close();
                        return;
                    }

                    foreach (string friend in friendsListBox.Items)
                    {
                        if (friend.ToString() == friendName)
                        {
                            MessageBox.Show("That user is already your friend!");
                            form.Close();
                            return;
                        }
                    }
                    form.addFriend();
                    friendsListBox.Items.Add(friendName);
                    form.Close();
                }
                else
                {
                    MessageBox.Show("Error adding friend.");
                }
                
            }

        }
    }
}

