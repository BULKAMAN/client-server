using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypt;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Elskom.Generic.Libs;

namespace Client1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private string keyBlowFish = "Hello";

        private void ClientConnectBut_Click(object sender, EventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            authorisation.ShowDialog();
            if (Authorisation.isClosed == true)
            {
                try
                {
                    client.Connect();
                    SendBut.Enabled = true;
                    ClientConnectBut.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void SendBut_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(SendMessageTextBox.Text))
                {
                    if (EncryptTypeCheckBox.SelectedIndex == 0)
                    {
                        string message = "";
                        message = Crypt.Class1.RsaEncrypt(SendMessageTextBox.Text);
                        message += "0";
                        client.Send(message);
                        richTextBoxReceiveMessage.Text += $"Me: {SendMessageTextBox.Text}{Environment.NewLine}";
                        SendMessageTextBox.Text = string.Empty;
                    }
                    else if (EncryptTypeCheckBox.SelectedIndex == 1)
                    {
                        BlowFish blowFishEnc = new BlowFish(keyBlowFish);
                        string message = "";
                        message = blowFishEnc.EncryptCBC(SendMessageTextBox.Text);
                        message = message + "1";
                        client.Send(message);
                        richTextBoxReceiveMessage.Text += $"Me: {SendMessageTextBox.Text}{Environment.NewLine}";
                        SendMessageTextBox.Text = string.Empty;
                    }
                }
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new(textBoxHost.Text);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            SendBut.Enabled = false;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string decMessage = "";
                string sendMessage = Encoding.UTF8.GetString(e.Data);
                if (Encoding.UTF8.GetString(e.Data)[Encoding.UTF8.GetString(e.Data).Length - 1] == '0')
                {

                    string message = Encoding.UTF8.GetString(e.Data).Remove(Encoding.UTF8.GetString(e.Data).Length - 1, 1);
                    decMessage = Crypt.Class1.RsaDecrypt(message);
                }
                else if (Encoding.UTF8.GetString(e.Data)[Encoding.UTF8.GetString(e.Data).Length - 1] == '1')
                {
                    string message = Encoding.UTF8.GetString(e.Data).Remove(Encoding.UTF8.GetString(e.Data).Length - 1, 1);
                    BlowFish blowFishDec = new BlowFish(keyBlowFish);
                    decMessage = blowFishDec.DecryptCBC(message);
                }
                richTextBoxReceiveMessage.Text += $"{e.IpPort} : {decMessage}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBoxReceiveMessage.Text += $"Server disconnected.{Environment.NewLine}";
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                richTextBoxReceiveMessage.Text += $"Server connected.{Environment.NewLine}";
            });
        }
    }

}
