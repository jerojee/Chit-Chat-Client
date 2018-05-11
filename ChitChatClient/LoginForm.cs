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
    public partial class LoginForm : Form
    {

        public Form RefToForm1 { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool Login()
        {
            var newUserInfo = new pbUserInfo
            {
                UserName = usernameBox.Text,
                Password = passwordBox.Text
            };
            var loginRequest = new pbLoginRequest()
            {
                userInfo = newUserInfo,
                Type = EventType.LOGIN
            };

            ClientInfo.clientUsername = usernameBox.Text;

            Serializer.SerializeWithLengthPrefix(ClientInfo.c.stream, loginRequest, PrefixStyle.Base128);

            Console.WriteLine("Sent message....");

            var loginStatus = Serializer.DeserializeWithLengthPrefix<pbResponse>(ClientInfo.c.stream, PrefixStyle.Base128);

            if(loginStatus != null && loginStatus.requestStatus)
            {
                var userInfo = Serializer.DeserializeWithLengthPrefix<pbInitialClientInfo>(ClientInfo.c.stream, PrefixStyle.Base128);
                ClientInfo.friendsList = userInfo.FriendList;
                return loginStatus.requestStatus;
            }


            return false;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton.PerformClick();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ClientInfo.c == null)
            {
                ClientInfo.c = new Client();
            }

          
            if (Login())
            {
                Console.WriteLine("LOGIN SUCCESS!");
                MainForm form = new MainForm();
                form.RefToForm2 = this;
                this.Visible = false;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (ClientInfo.c == null)
            {
                ClientInfo.c = new Client();
            }

            RegisterForm obj2 = new RegisterForm();
            obj2.RefToForm2 = this;
            this.Visible = false;
            obj2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
