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
    public partial class FormTask8 : Form
    {
        private int[] arrayA = new int[30];
        public FormTask8()
        {
            InitializeComponent();
        }

        private void FormTask8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxArray.Clear();

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = rand.Next(-100, 101); // Числа от -100 до 100
                textBoxArray.AppendText($"A[{i}] = {arrayA[i]}{Environment.NewLine}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arrayA.Length == 0 || textBoxArray.Text.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            int sum = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                // Проверка: отрицательный И нечетный (остаток от деления на 2 не равен 0)
                if (arrayA[i] < 0 && arrayA[i] % 2 != 0)
                {
                    sum += arrayA[i];
                }
            }

            textBoxResult.Text = $"Сумма нечетных отрицательных элементов: {sum}";
        }
    }
}
