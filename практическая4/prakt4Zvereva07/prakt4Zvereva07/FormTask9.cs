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
    public partial class FormTask9 : Form
    {
        private int[] arrayA = new int[30];
        public FormTask9()
        {
            InitializeComponent();
        }

        private void FormTask9_Load(object sender, EventArgs e)
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
                // Проверка условия: абсолютное значение элемента меньше квадрата индекса
                if (Math.Abs(arrayA[i]) < i * i)
                {
                    sum += arrayA[i];
                }
            }

            textBoxResult.Text = $"Сумма элементов по условию |a_i| < i²: {sum}";
        }
    }
}
