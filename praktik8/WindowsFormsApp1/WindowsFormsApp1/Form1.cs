using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка ввода
            if (!double.TryParse(textBox1.Text, out double x) ||
                !double.TryParse(textBox2.Text, out double y) ||
                !double.TryParse(textBox3.Text, out double z))
            {
                textBox4.Text = "Ошибка: введите числа!";
                return;
            }

            double result = 0;
            string formula = "";

            try
            {
                // Определяем, какой вариант выбран
                if (radioButton1.Checked)
                {
                    formula = "Вариант 1: y = x² + a, если x > a; x³ - a, если x = a; x·a + 5, если x < a";
                    double a1 = y;
                    if (x > a1)
                        result = x * x + a1;
                    else if (Math.Abs(x - a1) < 0.000001)
                        result = x * x * x - a1;
                    else
                        result = x * a1 + 5;
                }
                else if (radioButton2.Checked)
                {
                    formula = "Вариант 2: f = sin(x)+cos(y), если x>y; ln(x)+y², если x=y; e^x - sin(y), если x<y";
                    if (x > y)
                        result = Math.Sin(x) + Math.Cos(y);
                    else if (Math.Abs(x - y) < 0.000001)
                        result = Math.Log(x) + y * y;
                    else
                        result = Math.Exp(x) - Math.Sin(y);
                }
                else if (radioButton3.Checked)
                {
                    formula = "Вариант 3: z = √(a+b), если a>0; |a-b|, если a=0; a³ - b², если a<0";
                    double a3 = x;
                    double b3 = y;
                    if (a3 > 0)
                        result = Math.Sqrt(a3 + b3);
                    else if (Math.Abs(a3) < 0.000001)
                        result = Math.Abs(a3 - b3);
                    else
                        result = a3 * a3 * a3 - b3 * b3;
                }
                else if (radioButton4.Checked)
                {
                    formula = "Вариант 4: u = sin(x)·cos(y), если x·y>0; tg(x+y), если x·y=0; cos(x)+sin(y), если x·y<0";
                    if (x * y > 0)
                        result = Math.Sin(x) * Math.Cos(y);
                    else if (Math.Abs(x * y) < 0.000001)
                        result = Math.Tan(x + y);
                    else
                        result = Math.Cos(x) + Math.Sin(y);
                }
                else if (radioButton5.Checked)
                {
                    formula = "Вариант 5: v = |x-y|, если x>y; ln|x-y|, если x=y; e^|x-y|, если x<y";
                    if (x > y)
                        result = Math.Abs(x - y);
                    else if (Math.Abs(x - y) < 0.000001)
                        result = 0; // ln(1) = 0
                    else
                        result = Math.Exp(Math.Abs(x - y));
                }
                else if (radioButton6.Checked)
                {
                    formula = "Вариант 6: w = a·x² + b, если x≥0; a·sin(x) - b, если x<0";
                    double a6 = y;
                    double b6 = z;
                    if (x >= 0)
                        result = a6 * x * x + b6;
                    else
                        result = a6 * Math.Sin(x) - b6;
                }
                else if (radioButton7.Checked)
                {
                    formula = "Вариант 7: t = ln(a+b), если a+b>1; sin(a+b), если 0≤a+b≤1; cos(a+b), если a+b<0";
                    double a7 = x;
                    double b7 = y;
                    double sum = a7 + b7;
                    if (sum > 1)
                        result = Math.Log(sum);
                    else if (sum >= 0)
                        result = Math.Sin(sum);
                    else
                        result = Math.Cos(sum);
                }
                else if (radioButton8.Checked)
                {
                    formula = "Вариант 8: p = √(x²+y²), если x>y; √|x-y|, если x=y; (x+y)², если x<y";
                    if (x > y)
                        result = Math.Sqrt(x * x + y * y);
                    else if (Math.Abs(x - y) < 0.000001)
                        result = 1; // чтобы избежать 0 под корнем
                    else
                        result = (x + y) * (x + y);
                }
                else if (radioButton9.Checked)
                {
                    formula = "Вариант 9: q = a^b, если a>0; b^a, если a<0; 1, если a=0";
                    double a9 = x;
                    double b9 = y;
                    if (a9 > 0)
                        result = Math.Pow(a9, b9);
                    else if (a9 < 0)
                        result = Math.Pow(b9, a9);
                    else
                        result = 1;
                }
                else if (radioButton10.Checked)
                {
                    formula = "Вариант 10: r = max(a,b,c), если a>0; min(a,b,c), если a<0; (a+b+c)/3, если a=0";
                    double a10 = x;
                    double b10 = y;
                    double c10 = z;
                    if (a10 > 0)
                        result = Math.Max(a10, Math.Max(b10, c10));
                    else if (a10 < 0)
                        result = Math.Min(a10, Math.Min(b10, c10));
                    else
                        result = (a10 + b10 + c10) / 3.0;
                }
                else if (radioButton11.Checked)
                {
                    formula = "Вариант 11: s = sin(πx), если x>1; cos(πx), если 0≤x≤1; tg(πx), если x<0";
                    if (x > 1)
                        result = Math.Sin(Math.PI * x);
                    else if (x >= 0)
                        result = Math.Cos(Math.PI * x);
                    else
                        result = Math.Tan(Math.PI * x);
                }
                else if (radioButton12.Checked)
                {
                    formula = "Вариант 12: m = ln(1+x), если x>0; e^x - 1, если x=0; √|x|, если x<0";
                    if (x > 0)
                        result = Math.Log(1 + x);
                    else if (Math.Abs(x) < 0.000001)
                        result = 0; // e^0 - 1 = 0
                    else
                        result = Math.Sqrt(Math.Abs(x));
                }
                else
                {
                    textBox4.Text = "Ошибка: выберите вариант!";
                    return;
                }

                // Вывод результата
                textBox4.Text = formula + Environment.NewLine + Environment.NewLine;
                textBox4.Text += $"Входные данные: x = {x:F4}, y = {y:F4}, z = {z:F4}" + Environment.NewLine;
                textBox4.Text += $"Результат = {result:F6}";
            }
            catch (Exception ex)
            {
                textBox4.Text = $"Ошибка вычисления: {ex.Message}";
            }
        }
    }
}
