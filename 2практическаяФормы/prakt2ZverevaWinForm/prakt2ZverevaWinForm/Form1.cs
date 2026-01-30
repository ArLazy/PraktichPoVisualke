using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt2ZverevaWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double base1, base2, height, side, area, perimeter;

            
            base1 = Convert.ToDouble(textBoxBase1.Text);
            base2 = Convert.ToDouble(textBoxBase2.Text);
            height = Convert.ToDouble(textBoxHeight.Text);
            side = Convert.ToDouble(textBoxSide.Text);

           
            area = ((base1 + base2) / 2) * height;

            
            perimeter = base1 + base2 + height + side;

           
            textBoxArea.Text = area.ToString("F2");
            textBoxPerimeter.Text = perimeter.ToString("F2");
        }
    }
}
