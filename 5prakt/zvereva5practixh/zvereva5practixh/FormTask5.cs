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

    public partial class FormTask5 : Form
    {
        private int maxElementValue;
        private Point maxElementPosition;

        public FormTask5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 4;
            dataGridViewMatrix.ColumnCount = 3;

            // Очищаем предыдущее выделение
            ClearHighlight();

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

            // Находим наибольший элемент матрицы
            maxElementValue = matrix[0, 0];
            maxElementPosition = new Point(0, 0); // Запоминаем позицию

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] > maxElementValue)
                    {
                        maxElementValue = matrix[i, j];
                        maxElementPosition = new Point(i, j);
                    }
                }
            }

            // Выводим наибольший элемент в TextBox
            textBoxMaxElement.Text = maxElementValue.ToString();

            // Подсвечиваем наибольший элемент в DataGridView
            HighlightMaxElement();
        }

        private void ClearHighlight()
        {
            // Очищаем подсветку во всех ячейках
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Style.BackColor = Color.White;
                    dataGridViewMatrix.Rows[i].Cells[j].Style.ForeColor = Color.Black;
                }
            }
        }

        private void HighlightMaxElement()
        {
            // Подсвечиваем ячейку с наибольшим элементом
            if (maxElementPosition.X >= 0 && maxElementPosition.Y >= 0)
            {
                dataGridViewMatrix.Rows[maxElementPosition.X].Cells[maxElementPosition.Y].Style.BackColor = Color.Yellow;
                dataGridViewMatrix.Rows[maxElementPosition.X].Cells[maxElementPosition.Y].Style.ForeColor = Color.Red;
                dataGridViewMatrix.Rows[maxElementPosition.X].Cells[maxElementPosition.Y].Style.Font =
                    new Font(dataGridViewMatrix.Font, FontStyle.Bold);
            }
        }
    }
}
