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
    public partial class FormTask11 : Form
    {
        private double[] arrayA = new double[25];
        public FormTask11()
        {
            InitializeComponent();
        }

        private void FormTask11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxArray.Clear();

            for (int i = 0; i < arrayA.Length; i++)
            {
                // Генерируем вещественные числа в диапазоне от -5 до 5
                arrayA[i] = Math.Round(-5.0 + rand.NextDouble() * 10.0, 2);
                textBoxArray.AppendText($"A[{i}] = {arrayA[i]:F2}{Environment.NewLine}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arrayA.Length == 0 || textBoxArray.Text.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            int negativeCount = 0;
            int inSegmentCount = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                // Проверка на отрицательность
                if (arrayA[i] < 0)
                {
                    negativeCount++;
                }

                // Проверка принадлежности отрезку [1, 2] (включительно)
                if (arrayA[i] >= 1 && arrayA[i] <= 2)
                {
                    inSegmentCount++;
                }
            }

            textBoxResult.Text = $"Отрицательных: {negativeCount}, В отрезке [1,2]: {inSegmentCount}";
        }
    }
    }

