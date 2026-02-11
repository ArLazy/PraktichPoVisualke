using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zvereva5practixh
{
    public partial class FormTask4 : Form
    {
        public FormTask4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewOriginal.RowCount = 3;
            dataGridViewOriginal.ColumnCount = 4;
            dataGridViewResult.RowCount = 3;
            dataGridViewResult.ColumnCount = 4;

            int[,] matrix = new int[3, 4];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в первый DataGridView
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    dataGridViewOriginal.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Находим сумму элементов главной диагонали
            // Для прямоугольной матрицы 3x4 главная диагональ: [0,0], [1,1], [2,2]
            int diagonalSum = 0;
            int minDimension = Math.Min(3, 4); // В нашем случае 3
            for (int i = 0; i < minDimension; i++)
            {
                diagonalSum += matrix[i, i];
            }

            // Создаем копию матрицы для изменений
            int[,] modifiedMatrix = (int[,])matrix.Clone();

            // Заменяем последний элемент на сумму диагонали
            modifiedMatrix[2, 3] = diagonalSum;

            // Выводим измененную матрицу во второй DataGridView
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = modifiedMatrix[i, j].ToString();
                }
            }

            // Подсвечиваем измененный элемент
            dataGridViewResult.Rows[2].Cells[3].Style.BackColor = Color.Yellow;
        }
    }
}
