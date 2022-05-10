using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Client1
{
    public partial class Authorisation : Form
    {
        public static bool isClosed { get; private set; }

        public Authorisation()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private SqlConnection connection;
        private SqlCommand command, authorize, logincheck;
        private Regex passCheck = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        private bool IsClosed = false;

        private void textBox1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != 8 && (c < 65 || c > 95) && (c < 97 || c > 122) && (c < 48 || c > 57))
            {
                e.Handled = true;
            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            char z = e.KeyChar;
            if (z != 8 && (z < 65 || z > 95) && (z < 97 || z > 122) && (z < 48 || z > 57))
            {
                e.Handled = true;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (passCheck.IsMatch(Password.Text)) label2.Text = "Сложный пароль";
            else label2.Text = "Слабый пароль";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkPass.Text != Password.Text) label3.Text = "Пароли не совпадают!";
            else label3.Text = "";
        }

        private void signInWithoutReg_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            Login.Text = null;
            Password.Text = null;
            label6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            checkPass.Visible = false;
            registrationBut.Visible = false;
            signInBut.Visible = true;
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            logincheck = new SqlCommand("SELECT * FROM Users WHERE Login = @login", connection);
            logincheck.Parameters.AddWithValue("@login", Login.Text);
            if (Convert.ToInt32(logincheck.ExecuteScalar()) == 0)
            {
                command = new SqlCommand($"INSERT INTO [Users] (Login, Password) VALUES (@login, @password)", connection);

                command.Parameters.AddWithValue("login", Login.Text);
                command.Parameters.AddWithValue("password", GenerateHash(Password.Text));

                command.ExecuteNonQuery();

                label4.Visible = true;
                Login.Text = null;
                Password.Text = null;
                label6.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkPass.Visible = false;
                registrationBut.Visible = false;
                signInBut.Visible = true;
            }
            else if (Password.Text.Length < 8) MessageBox.Show("Пароль слишком маленький");
            else
            {
                MessageBox.Show("Такой аккаунт уже существует");
            }
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            authorize = new SqlCommand("SELECT * FROM Users WHERE Login = @login AND Password = @password", connection);
            authorize.Parameters.AddWithValue("@login", Login.Text);
            authorize.Parameters.AddWithValue("@password", GenerateHash(Password.Text));
            if (Convert.ToInt32(authorize.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Вы успешно вошли");
                IsClosed = true;
                isClosed = IsClosed;
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        public static int GenerateHash(string s)
        {
            int p = 31;
            int hash = 0;
            foreach (var c in s)
                hash = hash * p + c;
            return hash;
        }
    }
}
