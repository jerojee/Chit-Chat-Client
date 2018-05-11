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
    public partial class JoinChatForm : Form
    {
        public JoinChatForm()
        {
            InitializeComponent();
            confirmJoinChatButton.DialogResult = DialogResult.OK;
        }

        private void confirmJoinChatButton_Click(object sender, EventArgs e)
        {
  
        }

        public string getChatName()
        {
            return enterJoinChatNameBox.Text;
        }

        public bool getJoinChatName(string chatRoomName)
        {
        
            pbJoinChatRequest joinChat = new pbJoinChatRequest
            {
                ChatName = chatRoomName,
                Type = EventType.JOIN_CHAT
            };

            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, joinChat, PrefixStyle.Base128);

            return true;
        }

        private void enterJoinChatNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmJoinChatButton.PerformClick();
        }

        private void JoinChatForm_Load(object sender, EventArgs e)
        {

        }

        private void JoinChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
