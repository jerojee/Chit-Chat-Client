namespace ChitChatClient
{
    partial class CreateChatForm
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
            this.enterChatNameBox = new System.Windows.Forms.TextBox();
            this.confirmCreateChatButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterChatNameBox
            // 
            this.enterChatNameBox.Location = new System.Drawing.Point(86, 66);
            this.enterChatNameBox.Name = "enterChatNameBox";
            this.enterChatNameBox.Size = new System.Drawing.Size(319, 22);
            this.enterChatNameBox.TabIndex = 0;
            this.enterChatNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterChatNameBox_KeyDown);
            // 
            // confirmCreateChatButton
            // 
            this.confirmCreateChatButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmCreateChatButton.Location = new System.Drawing.Point(147, 103);
            this.confirmCreateChatButton.Name = "confirmCreateChatButton";
            this.confirmCreateChatButton.Size = new System.Drawing.Size(195, 32);
            this.confirmCreateChatButton.TabIndex = 1;
            this.confirmCreateChatButton.Text = "Create Chatroom";
            this.confirmCreateChatButton.UseVisualStyleBackColor = true;
            this.confirmCreateChatButton.Click += new System.EventHandler(this.confirmCreateChatButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.confirmCreateChatButton);
            this.groupBox1.Controls.Add(this.enterChatNameBox);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create chatroom name";
            // 
            // CreateChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(619, 197);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateChatForm";
            this.Text = "ChitChat";

            this.Text = "CreateChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateChatForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateChatForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox enterChatNameBox;
        private System.Windows.Forms.Button confirmCreateChatButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}