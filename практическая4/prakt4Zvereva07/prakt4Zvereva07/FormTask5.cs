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
    public partial class FormTask5 : Form
    {
        private double[] arrayX = new double[27]; // Исходный массив
        private double[] arrayY = new double[27];
        public FormTask5()
        {
            InitializeComponent();
        }

        private void FormTask5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxX.Clear();

            for (int i = 0; i < arrayX.Length; i++)
            {
                // Генерируем числа в диапазоне от -5.0 до 5.0
                // Ограничиваем диапазон, чтобы избежать очень больших чисел
                arrayX[i] = Math.Round(-5.0 + rand.NextDouble() * 10.0, 2);
                textBoxX.AppendText($"X[{i}] = {arrayX[i]:F2}{Environment.NewLine}");
            }

            // Очищаем предыдущие результаты
            textBoxY.Clear();
            textBoxCalculations.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arrayX.Length == 0 || textBoxX.Text.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив X.");
                return;
            }

            textBoxY.Clear();
            textBoxCalculations.Clear();

            // Счетчики для статистики
            int negativeYCount = 0;
            int positiveYCount = 0;
            int divisionByZeroCount = 0;

            // Вычисляем Y и дополнительные значения
            for (int i = 0; i < arrayX.Length; i++)
            {
                // 1. Вычисляем Y[i] = 6.85 * X[i]^2 - 1.52
                double xi = arrayX[i];
                arrayY[i] = 6.85 * Math.Pow(xi, 2) - 1.52;

                // Выводим Y[i]
                textBoxY.AppendText($"Y[{i}] = {arrayY[i]:F4}{Environment.NewLine}");

                // 2. В зависимости от Y[i] вычисляем a или b
                if (arrayY[i] < 0)
                {
                    // Вычисляем a = X[i]^3 - 0.62
                    double a = Math.Pow(xi, 3) - 0.62;
                    textBoxCalculations.AppendText($"Y[{i}] < 0: a = {xi:F2}³ - 0.62 = {a:F4}{Environment.NewLine}");
                    negativeYCount++;
                }
                else // Y[i] >= 0
                {
                    // Вычисляем b = 1 / X[i]^2, с проверкой деления на ноль
                    if (Math.Abs(xi) < 0.0001) // Практически ноль
                    {
                        textBoxCalculations.AppendText($"Y[{i}] >= 0: b = 1 / {xi:F2}² = ОШИБКА (деление на ноль){Environment.NewLine}");
                        divisionByZeroCount++;
                    }
                    else
                    {
                        double b = 1.0 / Math.Pow(xi, 2);
                        textBoxCalculations.AppendText($"Y[{i}] >= 0: b = 1 / {xi:F2}² = {b:F4}{Environment.NewLine}");
                        positiveYCount++;
                    }
                }
            }

            // Показываем статистику
            ShowStatistics(negativeYCount, positiveYCount, divisionByZeroCount);
        }
        private void ShowStatistics(int negativeCount, int positiveCount, int zeroErrorCount)
        {
            string stats = $"=== СТАТИСТИКА ВЫЧИСЛЕНИЙ ==={Environment.NewLine}" +
                          $"Всего элементов: {arrayX.Length}{Environment.NewLine}" +
                          $"Y[i] < 0 (вычисляли a): {negativeCount}{Environment.NewLine}" +
                          $"Y[i] >= 0 (вычисляли b): {positiveCount}{Environment.NewLine}" +
                          $"Ошибок деления на ноль: {zeroErrorCount}{Environment.NewLine}" +
                          $"=========================";

            MessageBox.Show(stats, "Статистика выполнения");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxX.Clear();
            textBoxY.Clear();
            textBoxCalculations.Clear();
            arrayX = new double[27];
            arrayY = new double[27];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (arrayY.Length == 0 || textBoxY.Text.Length == 0)
            {
                MessageBox.Show("Сначала выполните вычисления.");
                return;
            }

            // Находим min и max значения в массиве Y
            double minY = arrayY[0];
            double maxY = arrayY[0];
            int minIndex = 0, maxIndex = 0;

            for (int i = 1; i < arrayY.Length; i++)
            {
                if (arrayY[i] < minY)
                {
                    minY = arrayY[i];
                    minIndex = i;
                }
                if (arrayY[i] > maxY)
                {
                    maxY = arrayY[i];
                    maxIndex = i;
                }
            }

            string summary = $"=== СВОДКА ПО МАССИВУ Y ==={Environment.NewLine}" +
                            $"Минимальное Y[{minIndex}] = {minY:F4}{Environment.NewLine}" +
                            $"Максимальное Y[{maxIndex}] = {maxY:F4}{Environment.NewLine}" +
                            $"Соответствующее X[{minIndex}] = {arrayX[minIndex]:F2}{Environment.NewLine}" +
                            $"Соответствующее X[{maxIndex}] = {arrayX[maxIndex]:F2}{Environment.NewLine}" +
                            $"==========================";

            MessageBox.Show(summary, "Сводная информация");
        }
    }
    }
    

