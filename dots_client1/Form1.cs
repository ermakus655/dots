using dots_client1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dots_client1
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
                    arrChip[i, j].count = 0;
                    arrChip[i, j].team = "";
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
            arrChip[1, 4].count = 1;
            arrChip[4, 1].count = 1;
            arrChip[1, 4].team = "g";
            arrChip[4, 1].team = "b";
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
                for (int j = 0; j < 6; j++)
                {
                    if (arrChip[i, j].team == "b")
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
            int top = 0, bottom = 0, left = 0, right = 0;
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
            if (top == 1)
            {
                explosion(x, y - 1);
                top = 0;
            }
            if (bottom == 1)
            {
                explosion(x, y + 1);
                bottom = 0;
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((e.Location.X >= arrMap[i, j].x && e.Location.X <= arrMap[i, j].x + 136) && ((e.Location.Y >= arrMap[i, j].y && e.Location.Y <= arrMap[i, j].y + 136)))
                    {
                        if (arrChip[i, j].count != 0)
                        {
                            arrChip[i, j].count++;
                            if (arrChip[i, j].count == 4)
                                explosion(i, j);
                        }

                        Refresh(); break;
                    }
                }
            }
        }
    }
}
