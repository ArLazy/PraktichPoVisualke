using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practich7Zvereva
{


    public partial class Form1 : Form
    {

        private Point PreviousPoint;   // предыдущая точка при рисовании
        private Point CurrentPoint;    // текущая точка
        private Bitmap bmp;             // растровое изображение для работы
        private Pen pen;                // перо для рисования
        private Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = colorDialog.Color;
                }
            }
        }

        // Обработчик изменения толщины кисти


        private void Form1_Load(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, (float)nudPenWidth.Value);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP; *.JPG; *.GIF; *.TIF; *.PNG; *.ICO; *.EMF; *.WMF)|" +
                            "*.bmp;*.jpg;*.gif;*.tif;*.png;*.ico;*.emf;*.wmf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Загружаем изображение из файла
                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;

                // Создаём Bitmap и связываем с PictureBox
                bmp = new Bitmap(image, width, height);
                pictureBox1.Image = bmp;

                // Подготавливаем Graphics для рисования на PictureBox
                g = Graphics.FromImage(pictureBox1.Image);
            }
        }

        private void nudPenWidth_ValueChanged_1(object sender, EventArgs e)
        {
            if (pen != null)
                pen.Width = (float)nudPenWidth.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bmp == null) return; // если изображение не загружено

            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File (*.bmp)|*.bmp|" +
                "GIF File (*.gif)|*.gif|" +
                "JPEG File (*.jpg)|*.jpg|" +
                "TIF File (*.tif)|*.tif|" +
                "PNG File (*.png)|*.png";
            savedialog.ShowHelp = true;

            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                // Получаем расширение файла (последние 3 символа после точки)
                string ext = fileName.Substring(fileName.Length - 3).ToLower();

                switch (ext)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        MessageBox.Show("Неподдерживаемый формат файла");
                        break;
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (bmp == null) return; // изображение не загружено

            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bmp == null) return;           // изображение не загружено
            if (g == null) return;              // объект Graphics не создан
            if (e.Button == MouseButtons.Left)  // левая кнопка нажата
            {
                CurrentPoint.X = e.X;
                CurrentPoint.Y = e.Y;

                // Рисуем линию от предыдущей точки к текущей
                g.DrawLine(pen, PreviousPoint, CurrentPoint);

                // Обновляем предыдущую точку
                PreviousPoint.X = CurrentPoint.X;
                PreviousPoint.Y = CurrentPoint.Y;

                // Перерисовываем PictureBox
                pictureBox1.Invalidate();
            }
        }

        private void btnRandomPoints_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Создаём генератор случайных чисел
            Random rnd = new Random();

            // Рисуем 1000 случайных точек
            for (int i = 0; i < 1000; i++)
            {
                // Случайные координаты в пределах изображения
                int x = rnd.Next(bmp.Width);
                int y = rnd.Next(bmp.Height);

                // Случайные значения для RGB
                int R = rnd.Next(256);
                int G = rnd.Next(256);
                int B = rnd.Next(256);

                // Создаём цвет и устанавливаем пиксель
                Color randomColor = Color.FromArgb(255, R, G, B);
                bmp.SetPixel(x, y, randomColor);
            }

            // Обновляем отображение PictureBox
            pictureBox1.Invalidate();
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Проходим по всем пикселям изображения
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Получаем текущий цвет пикселя
                    Color pixelColor = bmp.GetPixel(x, y);

                    // Вычисляем среднее арифметическое трёх каналов
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    // Создаём новый цвет (все три канала равны gray, альфа-канал = 255)
                    Color newColor = Color.FromArgb(255, gray, gray, gray);

                    // Устанавливаем новый цвет пикселя
                    bmp.SetPixel(x, y, newColor);
                }
            }

            // Обновляем отображение в PictureBox
            pictureBox1.Invalidate();
        }

        private void btnSelectChannel_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Определяем, какой канал выбран
            bool keepRed = rbRed.Checked;
            bool keepGreen = rbGreen.Checked;
            bool keepBlue = rbBlue.Checked;

            // Проходим по всем пикселям
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int R = pixel.R;
                    int G = pixel.G;
                    int B = pixel.B;

                    // Обнуляем ненужные каналы
                    if (keepRed)
                    {
                        G = 0;
                        B = 0;
                    }
                    else if (keepGreen)
                    {
                        R = 0;
                        B = 0;
                    }
                    else if (keepBlue)
                    {
                        R = 0;
                        G = 0;
                    }

                    // Устанавливаем новый цвет
                    Color newColor = Color.FromArgb(255, R, G, B);
                    bmp.SetPixel(x, y, newColor);
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void Обрезать_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Получаем радиус из NumericUpDown
            int radius = (int)nudRadius.Value;

            // Вычисляем центр изображения
            int centerX = bmp.Width / 2;
            int centerY = bmp.Height / 2;

            // Проходим по всем пикселям
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Вычисляем квадрат расстояния от центра (чтобы избежать извлечения корня)
                    int dx = x - centerX;
                    int dy = y - centerY;
                    int distanceSquared = dx * dx + dy * dy;

                    // Если расстояние больше радиуса (в квадрате), закрашиваем чёрным
                    if (distanceSquared > radius * radius)
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                    // Иначе оставляем пиксель без изменений (ничего не делаем)
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            int side = (int)nudTriangleSide.Value; // длина стороны

            // Высота равностороннего треугольника: h = side * √3 / 2
            double height = side * Math.Sqrt(3) / 2.0;

            // Центр изображения
            double centerX = bmp.Width / 2.0;
            double centerY = bmp.Height / 2.0;

            // Вершины треугольника:
            // A – верхняя вершина (центр по X, смещение вверх на половину высоты)
            // B – левая нижняя вершина (смещение влево на половину стороны, вниз на половину высоты)
            // C – правая нижняя вершина (смещение вправо на половину стороны, вниз на половину высоты)
            PointF A = new PointF((float)centerX, (float)(centerY - height / 2));
            PointF B = new PointF((float)(centerX - side / 2), (float)(centerY + height / 2));
            PointF C = new PointF((float)(centerX + side / 2), (float)(centerY + height / 2));

            // Проходим по всем пикселям
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    // Если точка вне треугольника – закрашиваем синим
                    if (!IsPointInTriangle(new PointF(x, y), A, B, C))
                    {
                        bmp.SetPixel(x, y, Color.Blue);
                    }
                    // Внутри треугольника – пиксель остаётся без изменений
                }
            }

            // Обновляем PictureBox
            pictureBox1.Invalidate();
        }

        private bool IsPointInTriangle(PointF pt, PointF v1, PointF v2, PointF v3)
        {
            // Метод знаковых площадей (barycentric)
            float d1 = Sign(pt, v1, v2);
            float d2 = Sign(pt, v2, v3);
            float d3 = Sign(pt, v3, v1);

            bool hasNegative = (d1 < 0) || (d2 < 0) || (d3 < 0);
            bool hasPositive = (d1 > 0) || (d2 > 0) || (d3 > 0);

            // Точка внутри, если все знаки одинаковы (все положительные или все отрицательные)
            return !(hasNegative && hasPositive);
        }

        // Знак векторного произведения (p1-p3)×(p2-p3)
        private float Sign(PointF p1, PointF p2, PointF p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            int size = (int)nudRhombusSize.Value; // половина диагонали (по горизонтали и вертикали)
            int centerX = bmp.Width / 2;
            int centerY = bmp.Height / 2;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    double dx = Math.Abs(x - centerX);
                    double dy = Math.Abs(y - centerY);

                    // Проверка принадлежности ромбу: |dx|/size + |dy|/size <= 1
                    if (dx / size + dy / size <= 1)
                    {
                        // Внутри ромба – зелёный цвет
                        bmp.SetPixel(x, y, Color.Green);
                    }
                    else
                    {
                        // Снаружи ромба – градации серого
                        Color pixel = bmp.GetPixel(x, y);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(255, gray, gray, gray));
                    }
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void btnHorizlines_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Проходим по всем чётным строкам
            for (int y = 0; y < bmp.Height; y += 2)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    bmp.SetPixel(x, y, Color.Black);
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void btnVertiLines_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Проходим по всем нечётным столбцам
            for (int x = 1; x < bmp.Width; x += 2)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.Black);
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void btnSplitChannels_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            int width = bmp.Width;
            int height = bmp.Height;

            // Определяем середины (целочисленное деление)
            int halfW = width / 2;
            int halfH = height / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int R = pixel.R;
                    int G = pixel.G;
                    int B = pixel.B;

                    // Верхняя половина (y < halfH)
                    if (y < halfH)
                    {
                        if (x < halfW) // левая верхняя → красный
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, R, 0, 0));
                        }
                        else // правая верхняя → зелёный
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 0, G, 0));
                        }
                    }
                    else // нижняя половина (y >= halfH)
                    {
                        if (x < halfW) // левая нижняя → синий
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 0, 0, B));
                        }
                        else // правая нижняя → градации серого
                        {
                            int gray = (R + G + B) / 3;
                            bmp.SetPixel(x, y, Color.FromArgb(255, gray, gray, gray));
                        }
                    }
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    int R = pixel.R;
                    int G = pixel.G;
                    int B = pixel.B;

                    // Если синий канал доминирует над красным и зелёным
                    if (B > R && B > G)
                    {
                        // Заменяем на красный с яркостью исходного синего
                        bmp.SetPixel(x, y, Color.FromArgb(255, B, 0, 0));
                    }
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Сначала откройте изображение!");
                return;
            }

            // Проходим по всем пикселям
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixel = bmp.GetPixel(x, y);

                    // 1. Переводим в градации серого (усреднение каналов)
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // 2. Инвертируем (негатив)
                    int inverted = 255 - gray;

                    // 3. Устанавливаем новый цвет (одинаковый для всех каналов)
                    bmp.SetPixel(x, y, Color.FromArgb(255, inverted, inverted, inverted));
                }
            }

            // Обновляем отображение
            pictureBox1.Invalidate();
        }
    }
}

