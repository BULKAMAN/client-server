namespace Client2
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
            this.SendBut = new System.Windows.Forms.Button();
            this.SendMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientConnectBut = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.richTextBoxReceiveMessage = new System.Windows.Forms.RichTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // SendBut
            // 
            this.SendBut.Location = new System.Drawing.Point(430, 79);
            this.SendBut.Name = "SendBut";
            this.SendBut.Size = new System.Drawing.Size(75, 23);
            this.SendBut.TabIndex = 23;
            this.SendBut.Text = "Send";
            this.SendBut.UseVisualStyleBackColor = true;
            this.SendBut.Click += new System.EventHandler(this.SendBut_Click);
            // 
            // SendMessageTextBox
            // 
            this.SendMessageTextBox.Location = new System.Drawing.Point(14, 79);
            this.SendMessageTextBox.Name = "SendMessageTextBox";
            this.SendMessageTextBox.Size = new System.Drawing.Size(389, 23);
            this.SendMessageTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Host";
            // 
            // ClientConnectBut
            // 
            this.ClientConnectBut.Location = new System.Drawing.Point(328, 29);
            this.ClientConnectBut.Name = "ClientConnectBut";
            this.ClientConnectBut.Size = new System.Drawing.Size(75, 23);
            this.ClientConnectBut.TabIndex = 19;
            this.ClientConnectBut.Text = "Connect";
            this.ClientConnectBut.UseVisualStyleBackColor = true;
            this.ClientConnectBut.Click += new System.EventHandler(this.ClientConnectBut_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(205, 30);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 23);
            this.textBoxPort.TabIndex = 18;
            this.textBoxPort.Text = "8910";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(60, 30);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(100, 23);
            this.textBoxHost.TabIndex = 17;
            this.textBoxHost.Text = "127.0.0.1";
            // 
            // richTextBoxReceiveMessage
            // 
            this.richTextBoxReceiveMessage.Location = new System.Drawing.Point(14, 120);
            this.richTextBoxReceiveMessage.Name = "richTextBoxReceiveMessage";
            this.richTextBoxReceiveMessage.Size = new System.Drawing.Size(491, 212);
            this.richTextBoxReceiveMessage.TabIndex = 16;
            this.richTextBoxReceiveMessage.Text = "";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "RSA",
            "SHA256"});
            this.checkedListBox1.Location = new System.Drawing.Point(535, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(168, 94);
            this.checkedListBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 361);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.SendBut);
            this.Controls.Add(this.SendMessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientConnectBut);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.richTextBoxReceiveMessage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBut;
        private System.Windows.Forms.TextBox SendMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientConnectBut;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.RichTextBox richTextBoxReceiveMessage;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
