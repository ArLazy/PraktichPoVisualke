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
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridMatrix.RowCount = 3;
            dataGridMatrix.ColumnCount = 4;

            int[,] matrix = new int[3, 4];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в DataGridView
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    dataGridMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Находим минимальные элементы в каждой строке
            int[] minInRows = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                minInRows[i] = min;
            }

            // Выводим результаты во второй DataGridView (или ListBox)
            dataGridViewResults.RowCount = 3;
            dataGridViewResults.ColumnCount = 1;
            for (int i = 0; i < 3; i++)
            {
                dataGridViewResults.Rows[i].Cells[0].Value = minInRows[i].ToString();
            }
        }
    }
}
