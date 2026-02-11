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
    public partial class FormTask7 : Form
    {
        public FormTask7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 7;
            dataGridViewMatrix.ColumnCount = 7;

            // Устанавливаем размер DataGridView для результатов (7 строк, 1 столбец)
            dataGridViewMinValues.RowCount = 7;
            dataGridViewMinValues.ColumnCount = 2;

            // Устанавливаем заголовки для таблицы результатов
            dataGridViewMinValues.Columns[0].HeaderText = "Столбец";
            dataGridViewMinValues.Columns[1].HeaderText = "Наименьший элемент";

            int[,] matrix = new int[7, 7];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в DataGridView
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Находим наименьший элемент в каждом столбце
            for (int j = 0; j < 7; j++)
            {
                int minInColumn = matrix[0, j];

                for (int i = 1; i < 7; i++)
                {
                    if (matrix[i, j] < minInColumn)
                    {
                        minInColumn = matrix[i, j];
                    }
                }

                // Выводим результат в DataGridView
                dataGridViewMinValues.Rows[j].Cells[0].Value = (j + 1).ToString(); // Номер столбца (начиная с 1)
                dataGridViewMinValues.Rows[j].Cells[1].Value = minInColumn.ToString();
            }
        }
    }
}
