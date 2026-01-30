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
    public partial class FormTask4 : Form
    {
        private double[] array = new double[25];
        public FormTask4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxOriginal.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                // Генерируем вещественные числа в диапазоне от -100.0 до 100.0
                array[i] = Math.Round(-100.0 + rand.NextDouble() * 200.0, 2);
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

            // Находим индекс минимального элемента
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            // Меняем местами минимальный элемент с первым
            double firstValue = array[0];
            double minValue = array[minIndex];

            if (minIndex != 0)
            {
                // Выполняем обмен
                double temp = array[0];
                array[0] = array[minIndex];
                array[minIndex] = temp;

                // Показываем информацию об обмене
                MessageBox.Show($"Минимальный элемент array[{minIndex}] = {minValue:F2} " +
                              $"помещен на позицию array[0]{Environment.NewLine}" +
                              $"Первый элемент array[0] = {firstValue:F2} " +
                              $"перемещен на позицию array[{minIndex}]",
                              "Информация об обмене");
            }
            else
            {
                MessageBox.Show("Минимальный элемент уже является первым.",
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
                // Подсвечиваем поменяемые элементы
                string prefix = (i == 0 || i == Array.IndexOf(array, array[0])) ? ">>> " : "";
                textBoxResult.AppendText($"{prefix}array[{i}] = {array[i]:F2}{Environment.NewLine}");
            }
        }

        // Очистка всех полей
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOriginal.Clear();
            textBoxResult.Clear();
            array = new double[25]; // Сбрасываем массив
        }

        // Дополнительно: кнопка для поиска минимума без обмена
        private void buttonFindMinOnly_Click(object sender, EventArgs e)
        {
            if (array.Length == 0 || textBoxOriginal.Text.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив.");
                return;
            }

            double min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            MessageBox.Show($"Минимальный элемент: array[{minIndex}] = {min:F2}",
                          "Результат поиска");
        }
    }
    }

