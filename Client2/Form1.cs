using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Client2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);
        }

        SimpleTcpClient client;
        RSAParameters privateKey;
        RSAParameters publicKey;

        private void ClientConnectBut_Click(object sender, EventArgs e)
        {
            ClientConnectBut.Enabled = false;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBoxHost.Text);
            client.Connect(textBoxHost.Text, Convert.ToInt32(textBoxPort.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
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
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            string toEncrypt = SendMessageTextBox.Text;
            byte[] encBytes = RSAEncrypt(byteConverter.GetBytes(toEncrypt), publicKey, false);
            string encMessage = Convert.ToBase64String(encBytes);
            client.WriteLineAndGetReply(encMessage, TimeSpan.FromSeconds(3));
        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            
            RSA.ImportParameters(RSAKeyInfo);

             
            return RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
        }
    }
}
