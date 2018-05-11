namespace ChitChatClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.joinChatButton = new System.Windows.Forms.Button();
            this.createChatButton = new System.Windows.Forms.Button();
            this.logoffButton = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chatroomListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.addFriendButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.joinChatButton);
            this.groupBox1.Controls.Add(this.createChatButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 376);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // joinChatButton
            // 
            this.joinChatButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinChatButton.Location = new System.Drawing.Point(33, 79);
            this.joinChatButton.Margin = new System.Windows.Forms.Padding(4);
            this.joinChatButton.Name = "joinChatButton";
            this.joinChatButton.Size = new System.Drawing.Size(207, 36);
            this.joinChatButton.TabIndex = 18;
            this.joinChatButton.Text = "Join Chatroom";
            this.joinChatButton.UseVisualStyleBackColor = true;
            this.joinChatButton.Click += new System.EventHandler(this.joinChatButton_Click);
            // 
            // createChatButton
            // 
            this.createChatButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createChatButton.Location = new System.Drawing.Point(33, 23);
            this.createChatButton.Margin = new System.Windows.Forms.Padding(4);
            this.createChatButton.Name = "createChatButton";
            this.createChatButton.Size = new System.Drawing.Size(207, 36);
            this.createChatButton.TabIndex = 17;
            this.createChatButton.Text = "Create Chatroom";
            this.createChatButton.UseVisualStyleBackColor = true;
            this.createChatButton.Click += new System.EventHandler(this.createChatButton_Click);
            // 
            // logoffButton
            // 
            this.logoffButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoffButton.ForeColor = System.Drawing.Color.Black;
            this.logoffButton.Location = new System.Drawing.Point(86, 66);
            this.logoffButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoffButton.Name = "logoffButton";
            this.logoffButton.Size = new System.Drawing.Size(100, 38);
            this.logoffButton.TabIndex = 14;
            this.logoffButton.Text = "Log Off";
            this.logoffButton.UseVisualStyleBackColor = true;
            this.logoffButton.Click += new System.EventHandler(this.logoffButton_Click);
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.Color.White;
            this.friendsListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsListBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 22;
            this.friendsListBox.Location = new System.Drawing.Point(19, 141);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(265, 70);
            this.friendsListBox.TabIndex = 2;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.Location = new System.Drawing.Point(1073, 474);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(100, 32);
            this.sendMessageButton.TabIndex = 9;
            this.sendMessageButton.Text = "SEND";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(292, 12);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(880, 453);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsgBox.Location = new System.Drawing.Point(292, 478);
            this.txtMsgBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.Size = new System.Drawing.Size(772, 28);
            this.txtMsgBox.TabIndex = 12;
            this.txtMsgBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Friends";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chatrooms";
            // 
            // chatroomListBox
            // 
            this.chatroomListBox.BackColor = System.Drawing.Color.White;
            this.chatroomListBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatroomListBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.chatroomListBox.FormattingEnabled = true;
            this.chatroomListBox.ItemHeight = 22;
            this.chatroomListBox.Location = new System.Drawing.Point(19, 287);
            this.chatroomListBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatroomListBox.Name = "chatroomListBox";
            this.chatroomListBox.Size = new System.Drawing.Size(261, 70);
            this.chatroomListBox.TabIndex = 15;
            this.chatroomListBox.SelectedIndexChanged += new System.EventHandler(this.chatroomListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 53);
            this.label2.TabIndex = 16;
            this.label2.Text = "CHIT CHAT";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // addFriendButton
            // 
            this.addFriendButton.Location = new System.Drawing.Point(22, 223);
            this.addFriendButton.Name = "addFriendButton";
            this.addFriendButton.Size = new System.Drawing.Size(104, 28);
            this.addFriendButton.TabIndex = 17;
            this.addFriendButton.Text = "Add Friend";
            this.addFriendButton.UseVisualStyleBackColor = true;
            this.addFriendButton.Click += new System.EventHandler(this.addFriendButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1189, 522);
            this.Controls.Add(this.addFriendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoffButton);
            this.Controls.Add(this.chatroomListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMsgBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ChitChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtMsgBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoffButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox chatroomListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createChatButton;
        private System.Windows.Forms.Button joinChatButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button addFriendButton;
    }
}

