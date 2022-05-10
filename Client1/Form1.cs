using SimpleTCP;
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
                ClientConnectBut.Enabled = false;
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBoxHost.Text);
                client.Connect(textBoxHost.Text, Convert.ToInt32(textBoxPort.Text));
            }
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            richTextBoxReceiveMessage.Invoke((MethodInvoker)delegate ()
            {
                richTextBoxReceiveMessage.Text += e.MessageString;
            });
        }

        private void SendBut_Click(object sender, EventArgs e)
        {
            if(EncryptTypeCheckBox.SelectedIndex == 0)
            {
                string message = "";
                message = Crypt.Class1.RsaEncrypt(SendMessageTextBox.Text);
                message += "0";
                client.WriteLineAndGetReply(message, TimeSpan.FromSeconds(3));
            }
            else if(EncryptTypeCheckBox.SelectedIndex == 1)
            {
                BlowFish blowFishEnc = new BlowFish(keyBlowFish);
                string message = "";
                message = blowFishEnc.EncryptCBC(SendMessageTextBox.Text);
                message = message + "1";
                client.WriteLineAndGetReply(message,TimeSpan.FromSeconds(3));
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }
    }

}
