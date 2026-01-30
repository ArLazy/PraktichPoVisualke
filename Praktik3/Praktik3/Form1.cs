using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktik3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          for (int i =0; i<listBox1.Items.Count;i++)
            {
                string t = listBox1.Items[i].ToString();
                string r = "";
                for (int j = 0; j < t.Length;j++)
                {
                    char c = t[j];
                    if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    {
                        r += '+';
                    }
                    else r += c;
                }
                listBox1.Items[i] = r;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
