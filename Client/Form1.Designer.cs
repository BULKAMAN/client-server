namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReceiveMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.StartServerApp = new System.Windows.Forms.Button();
            this.StopServerApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerMessage = new System.Windows.Forms.TextBox();
            this.SendBut = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.ListBox();
            this.EncryptTypeCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ReceiveMessageRichTextBox
            // 
            this.ReceiveMessageRichTextBox.Location = new System.Drawing.Point(12, 126);
            this.ReceiveMessageRichTextBox.Name = "ReceiveMessageRichTextBox";
            this.ReceiveMessageRichTextBox.Size = new System.Drawing.Size(491, 316);
            this.ReceiveMessageRichTextBox.TabIndex = 0;
            this.ReceiveMessageRichTextBox.Text = "";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(58, 12);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(100, 23);
            this.HostTextBox.TabIndex = 1;
            this.HostTextBox.Text = "127.0.0.1:8910";
            // 
            // StartServerApp
            // 
            this.StartServerApp.Location = new System.Drawing.Point(182, 12);
            this.StartServerApp.Name = "StartServerApp";
            this.StartServerApp.Size = new System.Drawing.Size(75, 23);
            this.StartServerApp.TabIndex = 3;
            this.StartServerApp.Text = "Start";
            this.StartServerApp.UseVisualStyleBackColor = true;
            this.StartServerApp.Click += new System.EventHandler(this.StartServerApp_Click);
            // 
            // StopServerApp
            // 
            this.StopServerApp.Location = new System.Drawing.Point(284, 12);
            this.StopServerApp.Name = "StopServerApp";
            this.StopServerApp.Size = new System.Drawing.Size(75, 23);
            this.StopServerApp.TabIndex = 4;
            this.StopServerApp.Text = "Stop";
            this.StopServerApp.UseVisualStyleBackColor = true;
            this.StopServerApp.Click += new System.EventHandler(this.StopServerApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host";
            // 
            // ServerMessage
            // 
            this.ServerMessage.Location = new System.Drawing.Point(12, 54);
            this.ServerMessage.Name = "ServerMessage";
            this.ServerMessage.Size = new System.Drawing.Size(491, 23);
            this.ServerMessage.TabIndex = 7;
            // 
            // SendBut
            // 
            this.SendBut.Location = new System.Drawing.Point(12, 86);
            this.SendBut.Name = "SendBut";
            this.SendBut.Size = new System.Drawing.Size(75, 23);
            this.SendBut.TabIndex = 8;
            this.SendBut.Text = "Send";
            this.SendBut.UseVisualStyleBackColor = true;
            this.SendBut.Click += new System.EventHandler(this.SendBut_Click);
            // 
            // Clients
            // 
            this.Clients.FormattingEnabled = true;
            this.Clients.ItemHeight = 15;
            this.Clients.Location = new System.Drawing.Point(528, 123);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(200, 319);
            this.Clients.TabIndex = 9;
            // 
            // EncryptTypeCheckBox
            // 
            this.EncryptTypeCheckBox.FormattingEnabled = true;
            this.EncryptTypeCheckBox.Items.AddRange(new object[] {
            "RSA",
            "BlowFish"});
            this.EncryptTypeCheckBox.Location = new System.Drawing.Point(528, 15);
            this.EncryptTypeCheckBox.Name = "EncryptTypeCheckBox";
            this.EncryptTypeCheckBox.Size = new System.Drawing.Size(200, 94);
            this.EncryptTypeCheckBox.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 458);
            this.Controls.Add(this.EncryptTypeCheckBox);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.SendBut);
            this.Controls.Add(this.ServerMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopServerApp);
            this.Controls.Add(this.StartServerApp);
            this.Controls.Add(this.HostTextBox);
            this.Controls.Add(this.ReceiveMessageRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReceiveMessageRichTextBox;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.Button StartServerApp;
        private System.Windows.Forms.Button StopServerApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerMessage;
        private System.Windows.Forms.Button SendBut;
        private System.Windows.Forms.ListBox Clients;
        private System.Windows.Forms.CheckedListBox EncryptTypeCheckBox;
    }
}
