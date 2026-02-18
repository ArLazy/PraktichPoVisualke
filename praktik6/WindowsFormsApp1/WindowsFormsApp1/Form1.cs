using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void Form1_Paint(object sender, PaintEventArgs e)
            {
              
                Graphics g = e.Graphics; 
                g.Clear(Color.MistyRose);
                SolidBrush heartBrush = new SolidBrush(Color.Red);
                Pen heartPen = new Pen(Color.DarkRed, 3);
                g.FillEllipse(heartBrush, 200, 100, 120, 120);
                g.DrawEllipse(heartPen, 200, 100, 120, 120);
                g.FillEllipse(heartBrush, 300, 100, 120, 120);
                g.DrawEllipse(heartPen, 300, 100, 120, 120);
                Point[] heartPoints = {
        new Point(180, 160),
        new Point(440, 160),
        new Point(310, 280)
    };
                g.FillPolygon(heartBrush, heartPoints);
                g.DrawPolygon(heartPen, heartPoints);
                Font nameFont = new Font("Comic Sans MS", 20, FontStyle.Bold);
                SolidBrush textBrush = new SolidBrush(Color.White);
                string text1 = "Ара";
                string text2 = "+";
                string text3 = "Илья";
                g.DrawString(text1, nameFont, textBrush, 240, 150);
                g.DrawString(text2, nameFont, textBrush, 320, 150);
                g.DrawString(text3, nameFont, textBrush, 280, 190);
                SolidBrush smileBrush = new SolidBrush(Color.Yellow);
                g.FillEllipse(smileBrush, 450, 50, 100, 100);
                g.DrawEllipse(new Pen(Color.Black, 2), 450, 50, 100, 100);
                SolidBrush eyeBrush = new SolidBrush(Color.Black);
                g.FillEllipse(eyeBrush, 475, 80, 15, 20);
                g.FillEllipse(eyeBrush, 515, 80, 15, 20);
                Pen smilePen = new Pen(Color.Black, 3);
                g.DrawArc(smilePen, 475, 100, 50, 30, 0, 180);
                SolidBrush blushBrush = new SolidBrush(Color.Pink);
                g.FillEllipse(blushBrush, 460, 100, 15, 10);
                g.FillEllipse(blushBrush, 530, 100, 15, 10);
                int flowerX = 300;
                int flowerY = 350;
                Pen stemPen = new Pen(Color.Green, 4);
                g.DrawLine(stemPen, flowerX + 20, flowerY + 60, flowerX + 20, flowerY + 130);
                SolidBrush leafBrush = new SolidBrush(Color.Green);

                g.FillEllipse(leafBrush, flowerX, flowerY + 80, 25, 40);

                g.FillEllipse(leafBrush, flowerX + 15, flowerY + 95, 25, 40);
                SolidBrush petalBrush = new SolidBrush(Color.HotPink);
                g.FillEllipse(petalBrush, flowerX, flowerY, 35, 35);   
                g.FillEllipse(petalBrush, flowerX + 35, flowerY, 35, 35);  
                g.FillEllipse(petalBrush, flowerX + 17, flowerY - 20, 35, 35);
                g.FillEllipse(petalBrush, flowerX - 15, flowerY + 15, 35, 35); 
                g.FillEllipse(petalBrush, flowerX + 50, flowerY + 15, 35, 35); 
                SolidBrush centerBrush1 = new SolidBrush(Color.Yellow);
                SolidBrush centerBrush2 = new SolidBrush(Color.White);
                g.FillEllipse(centerBrush1, flowerX + 17, flowerY + 7, 30, 30);
                g.FillEllipse(centerBrush2, flowerX + 25, flowerY + 15, 10, 10);
                SolidBrush smallHeartBrush = new SolidBrush(Color.Pink);
                g.FillEllipse(smallHeartBrush, 100, 250, 20, 20);
                g.FillEllipse(smallHeartBrush, 115, 250, 20, 20);
                Point[] smallHeart1 = { new Point(95, 265), new Point(135, 265), new Point(115, 290) };
                g.FillPolygon(smallHeartBrush, smallHeart1);
                g.FillEllipse(smallHeartBrush, 550, 250, 20, 20);
                g.FillEllipse(smallHeartBrush, 565, 250, 20, 20);
                Point[] smallHeart2 = { new Point(545, 265), new Point(585, 265), new Point(565, 290) };
                g.FillPolygon(smallHeartBrush, smallHeart2);
                Font loveFont = new Font("Arial", 14, FontStyle.Italic);
                SolidBrush loveBrush = new SolidBrush(Color.Purple);
                g.DrawString("с любовью", loveFont, loveBrush, 270, 500);
            }
        }
    }

