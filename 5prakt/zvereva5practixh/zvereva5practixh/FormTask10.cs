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
    public partial class FormTask10 : Form
    {
        public FormTask10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 12;
            dataGridViewMatrix.ColumnCount = 12;

            // Устанавливаем размер DataGridView для сумм по столбцам
            // Можно сделать 1 строка, 12 столбцов или 12 строк, 2 столбца (номер столбца и сумма)
            dataGridViewColumnSums.RowCount = 12;
            dataGridViewColumnSums.ColumnCount = 2;
            dataGridViewColumnSums.Columns[0].HeaderText = "Столбец";
            dataGridViewColumnSums.Columns[1].HeaderText = "Сумма";

            int[,] matrix = new int[12, 12];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в DataGridView
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Вычисляем суммы по каждому столбцу
            for (int j = 0; j < 12; j++)
            {
                int columnSum = 0;

                for (int i = 0; i < 12; i++)
                {
                    columnSum += matrix[i, j];
                }

                // Выводим результат в DataGridView
                dataGridViewColumnSums.Rows[j].Cells[0].Value = (j + 1).ToString(); // Номер столбца (начиная с 1)
                dataGridViewColumnSums.Rows[j].Cells[1].Value = columnSum.ToString();
            }
        }
    }
}
