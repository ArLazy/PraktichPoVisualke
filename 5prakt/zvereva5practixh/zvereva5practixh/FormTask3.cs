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
    public partial class FormTask3 : Form
    {
        public FormTask3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 4;
            dataGridViewMatrix.ColumnCount = 4;

            int[,] matrix = new int[4, 4];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в DataGridView
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Находим наибольший элемент на главной диагонали
            int maxDiagonal = matrix[0, 0]; // Начинаем с первого элемента диагонали

            for (int i = 1; i < 4; i++)
            {
                if (matrix[i, i] > maxDiagonal)
                {
                    maxDiagonal = matrix[i, i];
                }
            }

            // Выводим результат
            textBoxMaxDiagonal.Text = maxDiagonal.ToString();
        }
    }
}
