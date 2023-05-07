using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dots_server
{
    public partial class server : Form
    {
        public const int port = 8010;
        public Socket tcpSocket;
        public int lisCount = 0;
        public int playerTurn = 1;
        public server()
        {
            InitializeComponent();
            portNum.Text = port.ToString();
        }
        public static string GetWirelessAdapterIPAddress()
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in interfaces)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    foreach (UnicastIPAddressInformation address in properties.UnicastAddresses)
                    {
                        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            return address.Address.ToString();
                        }
                    }
                }
            }
            return null;
        }
        private void server_Load(object sender, EventArgs e)
        {
            textBox1.Text = GetWirelessAdapterIPAddress();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Worker));
            thread.Start();
            start.Enabled = false;
            MessageBox.Show("server was launched");
        }
        private void Worker()
        {
            bool game = true;

            

            var tcpEndPoind = new IPEndPoint(IPAddress.Parse(textBox1.Text), port);
            tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoind);
            tcpSocket.Listen(2);
            var buffer = new byte[24];

            EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, port);
            EndPoint[] users = new EndPoint[2];
            Socket[] sockets= new Socket[2];
            while (lisCount < 2)
            {
                string s = null;
                var data = new StringBuilder();
                var listener = tcpSocket.Accept();
                if (sockets[0] == null)
                {
                    sockets[0] = listener;
                }
                else
                {
                    sockets[1] = listener;
                }
                var size = listener.Receive(buffer);
                data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                s = data.ToString();
                if (s == "color")
                {
                    if (users[0] == null)
                    {
                        users[0] = senderEndPoint;
                        listener.Send(Encoding.UTF8.GetBytes("green"));
                        lisCount++;
                    }
                    else
                    {
                        users[1] = senderEndPoint;
                        listener.Send(Encoding.UTF8.GetBytes("blue"));
                        lisCount++;
                    }
                }
            }

            
            while (game)
            {
                buffer = new byte[24];
                if (playerTurn == 1 && game)
                {
                   
                    var size = sockets[0].Receive(buffer);
                    var data = new StringBuilder();
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    string s = data.ToString();
                    if (s[s.Length - 1] == '!')
                    {
                        s = s.Remove(s.Length - 1);
                        game = false;
                    }
                    //string[] parts = s.Split(' ');
                    //sockets[0].Send(Encoding.UTF8.GetBytes("block"));
                    sockets[1].Send(Encoding.UTF8.GetBytes(s));
                    playerTurn = 2;
                }
                else if (playerTurn == 2 && game)
                {
                    var size = sockets[1].Receive(buffer);
                    var data = new StringBuilder();
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    string s = data.ToString();
                    if (s[s.Length - 1] == '!')
                    {
                        s = s.Remove(s.Length - 1);
                        game = false;
                    }
                    //string[] parts = s.Split(' ');
                    //sockets[1].Send(Encoding.UTF8.GetBytes("block"));
                    sockets[0].Send(Encoding.UTF8.GetBytes(s));
                    playerTurn= 1;
                }

            }
            tcpSocket.Close();
        }

        private void server_Leave(object sender, EventArgs e)
        {
            tcpSocket.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcpSocket.Close();
        }
    }
}
