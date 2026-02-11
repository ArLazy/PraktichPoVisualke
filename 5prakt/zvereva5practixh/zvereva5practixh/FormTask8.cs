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
    public partial class FormTask8 : Form
    {
        public FormTask8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 15;
            dataGridViewMatrix.ColumnCount = 15;

            // Устанавливаем размер DataGridView для строки результата
            dataGridViewResultRow.RowCount = 1;
            dataGridViewResultRow.ColumnCount = 15;

            int[,] matrix = new int[15, 15];
            Random rand = new Random();

            // Заполняем матрицу случайными числами и выводим в DataGridView
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    matrix[i, j] = rand.Next(-1000, 1000);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Находим наибольший элемент на главной диагонали и его позицию
            int maxDiagonal = matrix[0, 0];
            int maxRowIndex = 0;

            for (int i = 1; i < 15; i++)
            {
                if (matrix[i, i] > maxDiagonal)
                {
                    maxDiagonal = matrix[i, i];
                    maxRowIndex = i;
                }
            }

            // Выводим значение наибольшего элемента диагонали
            textBoxMaxDiagonal.Text = maxDiagonal.ToString();

            // Выводим всю строку с наибольшим элементом диагонали
            for (int j = 0; j < 15; j++)
            {
                dataGridViewResultRow.Rows[0].Cells[j].Value = matrix[maxRowIndex, j].ToString();
            }
        }
    }
}
