namespace Client1
{
    partial class Authorisation
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
            this.registrationBut = new System.Windows.Forms.Button();
            this.signInBut = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.checkPass = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.signInWithoutReg = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrationBut
            // 
            this.registrationBut.Location = new System.Drawing.Point(12, 170);
            this.registrationBut.Name = "registrationBut";
            this.registrationBut.Size = new System.Drawing.Size(97, 23);
            this.registrationBut.TabIndex = 0;
            this.registrationBut.Text = "Регистрация";
            this.registrationBut.UseVisualStyleBackColor = true;
            this.registrationBut.TextChanged += new System.EventHandler(this.signUp_Click);
            this.registrationBut.Click += new System.EventHandler(this.signUp_Click);
            // 
            // signInBut
            // 
            this.signInBut.Location = new System.Drawing.Point(12, 128);
            this.signInBut.Name = "signInBut";
            this.signInBut.Size = new System.Drawing.Size(75, 23);
            this.signInBut.TabIndex = 1;
            this.signInBut.Text = "Войти";
            this.signInBut.UseVisualStyleBackColor = true;
            this.signInBut.TextChanged += new System.EventHandler(this.signIn_Click);
            this.signInBut.Click += new System.EventHandler(this.signIn_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 31);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(236, 23);
            this.Login.TabIndex = 2;
            this.Login.Click += new System.EventHandler(this.textBox1_Click);
            this.Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // checkPass
            // 
            this.checkPass.Location = new System.Drawing.Point(12, 128);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(236, 23);
            this.checkPass.TabIndex = 3;
            this.checkPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 81);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(236, 23);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Регистрация успешна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Подтверждение пароля";
            // 
            // signInWithoutReg
            // 
            this.signInWithoutReg.Location = new System.Drawing.Point(12, 306);
            this.signInWithoutReg.Name = "signInWithoutReg";
            this.signInWithoutReg.Size = new System.Drawing.Size(137, 23);
            this.signInWithoutReg.TabIndex = 11;
            this.signInWithoutReg.Text = "Войти";
            this.signInWithoutReg.UseVisualStyleBackColor = true;
            this.signInWithoutReg.Click += new System.EventHandler(this.signInWithoutReg_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Зарегистрированы? Войдите";
            // 
            // Authorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 399);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signInWithoutReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.signInBut);
            this.Controls.Add(this.registrationBut);
            this.Name = "Authorisation";
            this.Text = "Authorisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrationBut;
        private System.Windows.Forms.Button signInBut;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox checkPass;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signInWithoutReg;
        private System.Windows.Forms.Label label7;
    }
}