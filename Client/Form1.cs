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
using System.Net;
using System.Security.Cryptography;
using Crypt;
using Elskom.Generic.Libs;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        string decMesssage;
        private string keyBlowFish = "Hello";

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            if(e.MessageString[e.MessageString.Length - 2] == '0')
            {

                string message = e.MessageString.Remove(e.MessageString.Length - 2, 2);
                decMesssage = Crypt.Class1.RsaDecrypt(message);
            }
            else if(e.MessageString[e.MessageString.Length - 2] == '1')
            {
                string message = e.MessageString.Remove(e.MessageString.Length - 2, 2);
                BlowFish blowFishDec = new BlowFish(keyBlowFish);
                decMesssage = blowFishDec.DecryptCBC(message);
            }
            ReceiveMessageRichTextBox.Invoke((MethodInvoker)delegate ()
            {
                ReceiveMessageRichTextBox.Text += decMesssage;
            });
        }

        private void StartServerApp_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(HostTextBox.Text);
                server.Start(ip, int.Parse(PortTextBox.Text));
            }
            catch
            {
                MessageBox.Show("Сервер уже запущен");
            }
        }

        private void StopServerApp_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
                server.Stop();
        }
    }
}
