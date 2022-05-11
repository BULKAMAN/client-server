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
using SuperSimpleTcp;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        string decMessage;
        private string keyBlowFish = "Hello";

        private void Form1_Load(object sender, EventArgs e)
        {
            SendBut.Enabled = false;
            server = new SimpleTcpServer(HostTextBox.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
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
                ReceiveMessageRichTextBox.Text += $"{e.IpPort} : {decMessage}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ReceiveMessageRichTextBox.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                Clients.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                ReceiveMessageRichTextBox.Text += $"{e.IpPort}  connected.{Environment.NewLine}";
                Clients.Items.Add(e.IpPort);
            });
        }

        private void StartServerApp_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start();
                ReceiveMessageRichTextBox.Text += $"Starting...{Environment.NewLine}";
                StartServerApp.Enabled = false;
                SendBut.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Сервер уже запущен");
            }
        }

        private void StopServerApp_Click(object sender, EventArgs e)
        {
            if(server.IsListening)
                server.Stop();
        }

        private void SendBut_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if(!string.IsNullOrEmpty(ServerMessage.Text) && Clients.SelectedItem != null)
                {
                    if (EncryptTypeCheckBox.SelectedIndex == 0)
                    {
                        string message = "";
                        message = Crypt.Class1.RsaEncrypt(ServerMessage.Text);
                        message += "0";
                        server.Send(Clients.SelectedItem.ToString(),message);
                        ReceiveMessageRichTextBox.Text += $"Server: {ServerMessage.Text}{Environment.NewLine}";
                        ServerMessage.Text = string.Empty;
                    }
                    else if (EncryptTypeCheckBox.SelectedIndex == 1)
                    {
                        BlowFish blowFishEnc = new BlowFish(keyBlowFish);
                        string message = "";
                        message = blowFishEnc.EncryptCBC(ServerMessage.Text);
                        message = message + "1";
                        server.Send(Clients.SelectedItem.ToString(),message);
                        ReceiveMessageRichTextBox.Text += $"Server: {ServerMessage.Text}{Environment.NewLine}";
                        ServerMessage.Text = string.Empty;
                    }
                }
            }
        }
    }
}
