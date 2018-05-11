using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoBuf;
using ChitChat.Events;

namespace ChitChatClient
{
    public partial class CreateChatForm : Form
    {
        public CreateChatForm()
        {
            InitializeComponent();
            confirmCreateChatButton.DialogResult = DialogResult.OK;
        }

        private void CreateChatForm_Load(object sender, EventArgs e)
        {

        }

        private void confirmCreateChatButton_Click(object sender, EventArgs e)
        {
  
        }

        public string getChatName()
        {
            return enterChatNameBox.Text;
        }

        public bool sendChatName(string chatRoomName)
        {
     
            pbCreateChatRequest newChat = new pbCreateChatRequest
            {
                ChatName = chatRoomName,
                Type = EventType.CREATE_CHAT
            };
            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, newChat, PrefixStyle.Base128);

            return true;
        }

        private void enterChatNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmCreateChatButton.PerformClick();
        }

        private void CreateChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
