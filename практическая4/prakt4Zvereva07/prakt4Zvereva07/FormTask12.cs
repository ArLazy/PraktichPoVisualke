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
    public partial class FormTask12 : Form
    {
        private double[] arrayC = new double[23];
        public FormTask12()
        {
            InitializeComponent();
        }

        private void FormTask12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxArray.Clear();

            for (int i = 0; i < arrayC.Length; i++)
            {
                // Генерируем вещественные числа в диапазоне от 0 до 10
                arrayC[i] = Math.Round(rand.NextDouble() * 10.0, 2);
                textBoxArray.AppendText($"C[{i}] = {arrayC[i]:F2}{Environment.NewLine}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arrayC.Length == 0 || textBoxArray.Text.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            double sum = 0;
            int count = 0;

            for (int i = 0; i < arrayC.Length; i++)
            {
                if (arrayC[i] > 3.5)
                {
                    sum += arrayC[i];
                    count++;
                }
            }

            if (count > 0)
            {
                double average = Math.Round(sum / count, 2);
                textBoxResult.Text = $"Среднее арифметическое значений > 3.5: {average}";
            }
            else
            {
                textBoxResult.Text = "Нет значений > 3.5";
            }
        }
    }
}
