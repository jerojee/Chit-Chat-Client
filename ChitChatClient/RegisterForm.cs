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
    public partial class RegisterForm : Form
    {
        public Form RefToForm2 { get; set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void regButtonClick(object sender, EventArgs e)
        {
            MainForm obj1 = new MainForm();
            obj1.RefToForm2 = this;
            this.Visible = false;
            obj1.Show();
            this.Hide();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string username = createUsernameBox.Text;
            string pass = createPasswordBox.Text;
            if(CreateNewAccount(username, pass))
            {
                LoginForm obj1 = new LoginForm();
                obj1.RefToForm1 = this;
                this.Visible = false;
                obj1.Show();
                this.Close();
            }
        }

        public bool CreateNewAccount(string username, string pass) //Client function
        {

            pbUserInfo info = new pbUserInfo
            {
                UserName = username,
                Password = pass,
                Type = EventType.USER_INFO
            };

            pbCreateAccountRequest account = new pbCreateAccountRequest
            {
                userInfo = info,
                Type = EventType.CREATE_ACCT
            };

            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, account, PrefixStyle.Base128);

            var createAccountStatus = Serializer.DeserializeWithLengthPrefix<pbResponse>(ClientInfo.c.stream, PrefixStyle.Base128);

            return createAccountStatus.requestStatus; 
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                createAccountButton.PerformClick();
        }
    }
}
