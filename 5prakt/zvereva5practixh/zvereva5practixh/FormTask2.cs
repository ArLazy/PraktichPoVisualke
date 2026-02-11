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
    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.RowCount = 3;
            dataGridViewMatrix.ColumnCount = 3;

            int[,] matrix = new int[3, 3];
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rand.Next(-10, 10);
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }

            // Сумма второй строки (индекс 1)
            int sum = 0;
            for (int j = 0; j < 3; j++)
                sum += matrix[1, j];

            // Произведение первого столбца (индекс 0)
            int product = 1;
            for (int i = 0; i < 3; i++)
                product *= matrix[i, 0];

            textBoxSum.Text = sum.ToString();
            textBoxProduct.Text = product.ToString();
        }
    }
}
