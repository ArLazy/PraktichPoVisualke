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
    public partial class FormTask3 : Form
    {
        private double[] array = new double[15];
        public FormTask3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxOriginal.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                // Генерируем вещественные числа в диапазоне от -50.0 до 50.0
                // NextDouble() дает число от 0.0 до 1.0
                array[i] = Math.Round(-50.0 + rand.NextDouble() * 100.0, 2); // Округляем до 2 знаков
                textBoxOriginal.AppendText($"array[{i}] = {array[i]:F2}{Environment.NewLine}");
            }

            textBoxResult.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array.Length == 0 || textBoxOriginal.Text.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            // Находим индекс максимального элемента
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Меняем местами максимальный элемент с последним
            int lastIndex = array.Length - 1;
            double maxValue = array[maxIndex];

            if (maxIndex != lastIndex)
            {
                // Выполняем обмен
                double temp = array[maxIndex];
                array[maxIndex] = array[lastIndex];
                array[lastIndex] = temp;

                // Показываем информацию об обмене
                MessageBox.Show($"Максимальный элемент array[{maxIndex}] = {maxValue:F2} " +
                              $"помещен на позицию array[{lastIndex}]",
                              "Информация об обмене");
            }
            else
            {
                MessageBox.Show("Максимальный элемент уже является последним.",
                              "Информация");
            }

            // Выводим результат
            DisplayResult();
        }

        // Метод для вывода результата
        private void DisplayResult()
        {
            textBoxResult.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                textBoxResult.AppendText($"array[{i}] = {array[i]:F2}{Environment.NewLine}");
            }
        }
    }
    }
