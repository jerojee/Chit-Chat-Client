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
    public partial class AddFriendForm : Form
    {
        public AddFriendForm()
        {
            InitializeComponent();
            confirmAddFriendButton.DialogResult = DialogResult.OK;
        }

        private void confirmAddFriendButton_Click(object sender, EventArgs e)
        {

        }

        public string getFriendName()
        {
            return enterFriendNameBox.Text;
        }

        public bool addFriend()
        {
            string friendName = enterFriendNameBox.Text;
            pbAddFriendRequest friendRequest = new pbAddFriendRequest
            {
                FriendName = friendName,
                UserName = ClientInfo.clientUsername,
                Type = EventType.ADD_FRIEND
            };

            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, friendRequest, PrefixStyle.Base128);

            return true;

        }

        private void AddFriendForm_Load(object sender, EventArgs e)
        {

        }

        private void AddFriendForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void enterFriendNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                confirmAddFriendButton.PerformClick();
        }
    }
}
