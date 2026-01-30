using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt4Zvereva07
{
    public partial class FormTask1 : Form
    {
        private int[] array = new int[20];
        public FormTask1()
        {
            InitializeComponent();
        }

        private void FormTask1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101);
                textBox1.AppendText($"array[{i}] = {array[i]}{Environment.NewLine}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Меняем местами
            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;

            // Вывод результата
            textBox2.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                textBox2.AppendText($"array[{i}] = {array[i]}{Environment.NewLine}");
            }
        }
    }
}
