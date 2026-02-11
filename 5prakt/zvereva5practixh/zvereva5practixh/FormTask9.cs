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
    public partial class FormTask9 : Form
    {
        public FormTask9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewOriginal.RowCount = 16;
            dataGridViewOriginal.ColumnCount = 16;
            dataGridViewResult.RowCount = 16;
            dataGridViewResult.ColumnCount = 16;

            int[,] matrix = new int[16, 16];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в первый DataGridView
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    matrix[i, j] = rand.Next(-1000, 1000);
                    dataGridViewOriginal.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Создаем копию матрицы для изменений
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Находим наибольший элемент в каждой строке и помещаем его на главную диагональ
            for (int i = 0; i < 16; i++)
            {
                // Находим наибольший элемент в текущей строке
                int maxInRow = matrix[i, 0];
                for (int j = 1; j < 16; j++)
                {
                    if (matrix[i, j] > maxInRow)
                    {
                        maxInRow = matrix[i, j];
                    }
                }

                // Помещаем наибольший элемент строки на главную диагональ
                resultMatrix[i, i] = maxInRow;
            }

            // Выводим результирующую матрицу во второй DataGridView
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = resultMatrix[i, j].ToString();
                }
            }

            // Подсвечиваем элементы главной диагонали в результирующей матрице
            for (int i = 0; i < 16; i++)
            {
                dataGridViewResult.Rows[i].Cells[i].Style.BackColor = Color.LightYellow;
            }
        }
    }
}
