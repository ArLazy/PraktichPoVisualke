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
    public partial class FormTask2 : Form
    {
        private int[] array = new int[10];
        public FormTask2()
        {
            InitializeComponent();
        }

        private void FormTask2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 101); // Диапазон -100..100
                textBox1.AppendText($"array[{i}] = {array[i]}{Environment.NewLine}");
            }

            textBox2.Clear(); // Очищаем результаты при новой генерации
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            // Находим индекс минимального элемента
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            // Меняем местами минимальный элемент с последним
            int lastIndex = array.Length - 1;

            // Если минимальный уже последний, ничего не меняем
            if (minIndex != lastIndex)
            {
                int temp = array[minIndex];
                array[minIndex] = array[lastIndex];
                array[lastIndex] = temp;

                // Показываем, какой элемент был минимальным
                MessageBox.Show($"Минимальный элемент array[{minIndex}] = {temp} " +
                              $"помещен на позицию array[{lastIndex}]");
            }
            else
            {
                MessageBox.Show("Минимальный элемент уже является последним.");
            }

            // Выводим результат
            textBox2.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                textBox2.AppendText($"array[{i}] = {array[i]}{Environment.NewLine}");
            }
        }
    }
}
