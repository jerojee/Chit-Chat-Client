﻿namespace ChitChatClient
{
    partial class JoinChatForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmJoinChatButton = new System.Windows.Forms.Button();
            this.enterJoinChatNameBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.confirmJoinChatButton);
            this.groupBox1.Controls.Add(this.enterJoinChatNameBox);
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter chatroom name";
            // 
            // confirmJoinChatButton
            // 
            this.confirmJoinChatButton.Location = new System.Drawing.Point(147, 104);
            this.confirmJoinChatButton.Name = "confirmJoinChatButton";
            this.confirmJoinChatButton.Size = new System.Drawing.Size(195, 32);
            this.confirmJoinChatButton.TabIndex = 1;
            this.confirmJoinChatButton.Text = "Join Chatroom";
            this.confirmJoinChatButton.UseVisualStyleBackColor = true;
            this.confirmJoinChatButton.Click += new System.EventHandler(this.confirmJoinChatButton_Click);
            // 
            // enterJoinChatNameBox
            // 
            this.enterJoinChatNameBox.Location = new System.Drawing.Point(86, 66);
            this.enterJoinChatNameBox.Name = "enterJoinChatNameBox";
            this.enterJoinChatNameBox.Size = new System.Drawing.Size(319, 22);
            this.enterJoinChatNameBox.TabIndex = 0;
            this.enterJoinChatNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterJoinChatNameBox_KeyDown);
            // 
            // ChitChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(557, 219);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChitChat";
            this.Text = "JoinChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JoinChatForm_FormClosed);
            this.Load += new System.EventHandler(this.JoinChatForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmJoinChatButton;
        private System.Windows.Forms.TextBox enterJoinChatNameBox;
    }
}