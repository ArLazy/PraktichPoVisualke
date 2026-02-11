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
    public partial class FormTask6 : Form
    {
        public FormTask6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 4;
            dataGridViewMatrix.ColumnCount = 3;

            int[,] matrix = new int[4, 3];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в DataGridView
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Считаем количество положительных элементов
            int positiveCount = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        positiveCount++;
                    }
                }
            }

            // Выводим результат
            textBoxPositiveCount.Text = positiveCount.ToString();
        }
    }
}
