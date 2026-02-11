using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zvereva5practixh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task1 task1 = new task1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTask2 formTask2 = new FormTask2();
            formTask2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTask3 formTask3 = new FormTask3();
            formTask3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormTask4 formTask4 = new FormTask4();
            formTask4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTask5 formTask5 = new FormTask5();
            formTask5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormTask6 formTask6 = new FormTask6();
            formTask6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormTask7 formTask7 = new FormTask7();
            formTask7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormTask8 formTask8 = new FormTask8();
            formTask8.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormTask9 formTask9 = new FormTask9();
            formTask9.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormTask10 formTask10 = new FormTask10();
            formTask10.Show();
        }
    }
}
