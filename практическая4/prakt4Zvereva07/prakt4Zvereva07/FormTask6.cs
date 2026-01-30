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
    public partial class FormTask6 : Form
    {
        private double[] arrayR = new double[25];
        public FormTask6()
        {
            InitializeComponent();
        }

        private void FormTask6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxOriginal.Clear();

            for (int i = 0; i < arrayR.Length; i++)
            {
                // Генерируем числа в диапазоне от -20 до 20
                arrayR[i] = rand.Next(-20, 21);
                textBoxOriginal.AppendText($"R[{i}] = {arrayR[i]}{Environment.NewLine}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();

            for (int i = 0; i < arrayR.Length; i++)
            {
                if (arrayR[i] < 0)
                {
                    // Отрицательные: заменить квадратом
                    arrayR[i] = Math.Pow(arrayR[i], 2);
                }
                else if (arrayR[i] > 0)
                {
                    // Положительные: увеличить на 7
                    arrayR[i] += 7;
                }
                // Нулевые: оставить без изменения (ничего не делаем)

                // Выводим преобразованный элемент
                textBoxResult.AppendText($"R[{i}] = {arrayR[i]}{Environment.NewLine}");
            }
        }
    }
}
