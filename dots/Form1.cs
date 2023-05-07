using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dots
{
    public partial class Form1 : Form
    {
        public Bitmap map = Resource1.field;
        public Bitmap g1 = Resource1.green1;
        public Bitmap g2 = Resource1.green2;
        public Bitmap g3 = Resource1.green3;
        public Bitmap g4 = Resource1.green4;
        public Bitmap b1 = Resource1.blue1;
        public Bitmap b2 = Resource1.blue2;
        public Bitmap b3 = Resource1.blue3;
        public Bitmap b4 = Resource1.blue4;
        public Bitmap bl1 = Resource1.bluetleft2;
        public Bitmap bl2 = Resource1.bluehor;
        public Bitmap bl3 = Resource1.bluetleft1;
        public Bitmap exp = Resource1.explosion;
        public struct coordinates { public int x; public int y; };
        public struct chip { public string team; public int count; };
        public coordinates[,] arrMap = new coordinates[6, 6];
        public chip[,] arrChip = new chip[6, 6];
        public int drawX = 0, drawY = 0;
        public bool twist = false, GameIsNotOver = true;
        public string teamColor = "";
        public EndPoint tcpEndPoind;
        public Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public int x = 0, y = 0;
        public Color[] arrColors = new Color[2];


        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint, true);
            UpdateStyles();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arrChip[i,j].count = 0;
                    arrChip[i,j].team = "";
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arrMap[i, j].x = j * 134 + 360;
                    arrMap[i, j].y = i * 134 + 20;
                }
            }
            arrChip[1, 4].count = 3;
            arrChip[4, 1].count = 3;
            arrChip[1, 4].team = "green";
            arrChip[4, 1].team = "blue";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(map, new Rectangle(360, 20, 806, 806));
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if (arrChip[i, j].team == "blue")
                    {
                        switch (arrChip[i, j].count)
                        {
                            case 1:
                                g.DrawImage(b1, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                            case 2:
                                g.DrawImage(b2, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                            case 3:
                                g.DrawImage(b3, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                            case 4:
                                    g.DrawImage(b4, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));

                                break;
                        }
                    }
                    else
                    {
                        switch (arrChip[i, j].count)
                        {
                            case 1:
                                g.DrawImage(g1, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                            case 2:
                                g.DrawImage(g2, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                            case 3:
                                g.DrawImage(g3, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                            case 4:
                                g.DrawImage(g4, new Rectangle(arrMap[i, j].x + 6, arrMap[i, j].y + 6, 126, 126));
                                break;
                        }
                    }
                }
            }
        }
        private void explosion(int x, int y)
        {
            int top = 0, bottom = 0, left = 0,  right = 0;
            Refresh();
            Thread.Sleep(500);
            arrChip[x, y].count = 0;
            if (x > 0)
            {
                arrChip[x - 1, y].count++;
                arrChip[x - 1, y].team = arrChip[x, y].team;
                if (arrChip[x - 1, y].count == 4)
                {
                    left = 1; 
                }
            }
            if (x < 5)
            { 
            arrChip[x + 1, y].count++;
            arrChip[x + 1, y].team = arrChip[x, y].team;
                if (arrChip[x + 1, y].count == 4)
                {
                    right = 1;
                }
            }
            if (y > 0)
            {
                arrChip[x, y - 1].count++;
                arrChip[x, y - 1].team = arrChip[x, y].team;
                    if (arrChip[x, y - 1].count == 4)
                    {
                        top = 1;
                    }
            }
            if (y < 5)
            {
                arrChip[x, y + 1].count++;
                arrChip[x, y + 1].team = arrChip[x, y].team;
                    if (arrChip[x, y + 1].count == 4)
                    {
                        bottom = 1;
                    }
            }
            Refresh();
            if (left == 1)
            {
                explosion(x - 1, y);
                left = 0;
            }
            if (right == 1)
            {
                explosion(x + 1, y);
                right = 0;
            }
            if(top == 1)
            {
                explosion(x, y - 1);
                top = 0;
            }
            if(bottom == 1)
            {
                explosion(x, y + 1);
                bottom = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(userPort.Text, out int val);
            if(val <= 1024 || val >= 65000)
            {
                MessageBox.Show("wrong port");
            }
            else
            {
                userPort.Enabled= false;
            }
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
        private void accepter(string s)
        {
            string[] parts = s.Split(' ');
            int.TryParse((parts[0]), out int i);
            int.TryParse((parts[1]), out int j);
            arrChip[i, j].count++;
            if (arrChip[i, j].count == 4)
                explosion(i, j);
            Refresh();
            GameIsOver(2);
            picTurn.BackColor = arrColors[0];
        }
        private void start_Click(object sender, EventArgs e)
        {
            string str = "color";
            string ip = GetWirelessAdapterIPAddress();//
            int.TryParse(serPort.Text, out int port);
            tcpEndPoind = new IPEndPoint(IPAddress.Parse(serIP.Text), port);
            tcpSocket.Connect(tcpEndPoind);
            char[] charArray = str.ToCharArray();
            var data = Encoding.UTF8.GetBytes(charArray);
            tcpSocket.Send(data);
            var buffer = new byte[7];
            var answer = new StringBuilder();
            var size = tcpSocket.Receive(buffer);
            answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            str = answer.ToString();    
            if (str  == "green")
            {
                teamColor = "green";
                picTeam.BackColor = Color.FromArgb(0,192,0);
                arrColors[0] = Color.FromArgb(0, 192, 0);
                arrColors[1] = Color.Blue;
                twist = true;
                turn.Visible = true;
                picTeam.Visible = true; 
            }
            else if (str == "blue")
            {
                teamColor = "blue";
                picTeam.BackColor = Color.Blue;
                arrColors[0] = Color.Blue;
                arrColors[1] = Color.FromArgb(0, 192, 0);
                var buffer1 = new byte[7];
                var answer1 = new StringBuilder();
                var size1 = tcpSocket.Receive(buffer1);
                answer1.Append(Encoding.UTF8.GetString(buffer1, 0, size1));
                string s = answer1.ToString();
                twist = true;
                turn.Visible = true;
                picTeam.Visible = true;
                accepter(s);

            }
            //size = tcpSocket.Receive(buffer);
            //answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            //str = answer.ToString();
            //if (str == "ready" && teamColor == "green")
            //{
            //    twist = true;
            //}

        }
        private void sendData(int x, int y)
        {
            if (GameIsNotOver && !twist)
            {
                string str = x + " " + y;
                char[] charArray = str.ToCharArray();
                var data = Encoding.UTF8.GetBytes(charArray);
                tcpSocket.Send(data);
                var buffer = new byte[7];
                var answer = new StringBuilder();
                var size = tcpSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                str = answer.ToString();
                twist = true;
                accepter(str);
                
            }
        }
        private void ending(string winner, int send)
        {
            twist = false;
            MessageBox.Show("Game over. " + winner + " team won.");
            if (send == 1)
            {
                string str = x + " " + y + "!";
                char[] charArray = str.ToCharArray();
                var data = Encoding.UTF8.GetBytes(charArray);
                tcpSocket.Send(data);

            }
            tcpSocket.Close();
        }
        private string GameIsOver(int send)
        {
            string winner;
            Boolean blue = true, green = true;  
            for (int i = 0; i < 6 && green; i++)
            {
                for (int j = 0; j < 6 && green; j++)
                {
                    if (arrChip[i, j].team == "blue")
                    {
                        green = false;
                    }
                }
            }
            for (int i = 0; i < 6 && blue; i++)
            {
                for (int j = 0; j < 6 && blue; j++)
                {
                    if (arrChip[i, j].team == "green")
                    {
                        blue = false;
                    }
                }
            }
            if (green)
            {
                winner = "Green";
                ending(winner, send);
            }
            else if (blue)
            {
                winner = "Blue";
                ending(winner, send);
            }
            else
                winner = null;

            return winner;

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = -1;
            y = -1;
            if (twist)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if ((e.Location.X >= arrMap[i, j].x && e.Location.X <= arrMap[i, j].x + 136) && ((e.Location.Y >= arrMap[i, j].y && e.Location.Y <= arrMap[i, j].y + 136)))
                        {
                            if (arrChip[i, j].count != 0)
                            {
                                if ((teamColor == "green" && arrChip[i, j].team == "green") || (teamColor == "blue" && arrChip[i, j].team == "blue"))
                                {
                                    arrChip[i, j].count++;
                                    x = i; 
                                    y = j;
                                }
                                if (arrChip[i, j].count == 4)
                                    explosion(i, j);
                            }

                            Refresh(); break;
                        }
                    }
                }
                if (x != -1 && y != -1)
                {
                    if (GameIsOver(1) == null)
                    {
                        twist = false;
                        picTurn.BackColor = arrColors[1];
                        sendData(x, y);
                    }
                }
            }
        }
    }
}
