using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoBuf;
using ChitChat.Events;

namespace ChitChatClient
{
    public partial class OpenChatForm : Form
    {
        string chatRoomName;

        public Form RefToForm4 { get; set; }
        public OpenChatForm()
        {
            InitializeComponent();
            chatRoomName = MainForm.Current.getSelectedChatroom();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void submitButtonClick(object sender, EventArgs e)
        {
            string outgoingMessage = txtMsg.Text;
            SendAMessage(outgoingMessage,chatRoomName);

            chatBox.AppendText("\r\n" + ClientInfo.clientUsername + ": " + outgoingMessage); //Write message to chat box window

            using (StreamWriter txt = new StreamWriter("Register.txt"))
            {
                txt.Write(chatBox.Text);

            }
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

            //var messageStatus = Serializer.DeserializeWithLengthPrefix<pbResponse>(ClientInfo.c.stream, PrefixStyle.Base128);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = txtMsg.Text + Environment.NewLine;

            //These two lines of code, in tandem, allow the scrollbar to stay "fixed" at the bottom of the chatlog if something is entered in. It automatically scrolls downwards if not already at the bottom of the chatlog. (though as a feature this may be annoying for extended discussions)
            chatBox.SelectionStart = chatBox.Text.Length;
            chatBox.ScrollToCaret();

        }

        private void homeButtonClicked(object sender, EventArgs e)
        {          
            this.Hide();
            MainForm.Current.Show();
        }

        private void OpenChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Current.Show();
        }
    }
}
