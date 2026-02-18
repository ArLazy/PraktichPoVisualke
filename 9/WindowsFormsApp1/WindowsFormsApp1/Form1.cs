using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Animation9
{
    public partial class Form1 : Form
    {
        // ---------- ОБЩИЕ ПЕРЕМЕННЫЕ ----------
        private Random rand = new Random();
        private int currentAnimation = 1;      // текущая анимация (1-10)
        private double t = 0;                   // параметр времени

        // Для синусоиды
        private int sinX, sinY;

        // Для спирали
        private int spiralX, spiralY;

        // Для снежинки
        private int snowX = 100, snowY = 50;

        // Для мячика
        private int ballX = 100, ballY = 200;
        private int ballSpeedX = 5, ballSpeedY = 2;

        // Для звезд (10 штук)
        private int[] starX = new int[10];
        private int[] starY = new int[10];

        // Для хаотичной звезды
        private int chaosX = 300, chaosY = 200;

        // Для ракеты
        private int rocketY;
        private bool rocketLaunch = false;

        // Для броуновского движения
        private int brownX = 300, brownY = 200;

        // Для часов
        private int seconds = 0, minutes = 0, hours = 0;

        // Для автомобиля
        private int carX = 50;
        private int wheelAngle = 0;

        // Конструктор
        public Form1()
        {
            InitializeComponent();

            // Включаем двойную буферизацию (нет мерцания)
            this.DoubleBuffered = true;

            // Начальные позиции
            ResetPositions();

            // Подписываемся на события (на всякий случай)
            this.Paint += Form1_Paint;
            this.Resize += Form1_Resize;
        }

        // Сброс позиций при смене анимации
        private void ResetPositions()
        {
            t = 0;

            // Снежинка
            snowX = rand.Next(50, this.ClientSize.Width - 50);
            snowY = 50;

            // Мячик
            ballX = 100;
            ballY = 200;
            ballSpeedX = 5;
            ballSpeedY = 2;

            // Звезды
            for (int i = 0; i < 10; i++)
            {
                starX[i] = rand.Next(this.ClientSize.Width);
                starY[i] = rand.Next(this.ClientSize.Height);
            }

            // Хаотичная звезда
            chaosX = this.ClientSize.Width / 2;
            chaosY = this.ClientSize.Height / 2;

            // Ракета
            rocketY = this.ClientSize.Height - 150;
            rocketLaunch = false;

            // Броуновское движение
            brownX = this.ClientSize.Width / 2;
            brownY = this.ClientSize.Height / 2;

            // Часы
            seconds = DateTime.Now.Second;
            minutes = DateTime.Now.Minute;
            hours = DateTime.Now.Hour % 12;

            // Автомобиль
            carX = 50;
            wheelAngle = 0;
        }

        // Обработчик изменения размера окна
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResetPositions();
            this.Invalidate();
        }

        // ---------- ТАЙМЕР (движение) ----------
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 0.05;

            switch (currentAnimation)
            {
                case 1: // Синусоида
                    sinX = (int)(t * 5) % this.ClientSize.Width;
                    sinY = this.ClientSize.Height / 2 + (int)(100 * Math.Sin(t));
                    break;

                case 2: // Спираль
                    int cx = this.ClientSize.Width / 2;
                    int cy = this.ClientSize.Height / 2;
                    double r = 3 * t;
                    spiralX = cx + (int)(r * Math.Cos(t));
                    spiralY = cy + (int)(r * Math.Sin(t));
                    break;

                case 3: // Снежинка
                    snowY += 3;
                    if (snowY > this.ClientSize.Height)
                    {
                        snowY = 0;
                        snowX = rand.Next(this.ClientSize.Width);
                    }
                    break;

                case 4: // Мячик
                    ballY += ballSpeedY;
                    ballX += ballSpeedX;

                    // Гравитация
                    ballSpeedY += 1;

                    // Пол
                    if (ballY > this.ClientSize.Height - 70)
                    {
                        ballY = this.ClientSize.Height - 70;
                        ballSpeedY = -(int)(ballSpeedY * 0.7);
                    }

                    // Стены
                    if (ballX > this.ClientSize.Width - 40 || ballX < 0)
                        ballSpeedX = -ballSpeedX;
                    break;

                case 5: // Падающие звезды
                    for (int i = 0; i < 10; i++)
                    {
                        starY[i] += rand.Next(1, 4);
                        if (starY[i] > this.ClientSize.Height)
                        {
                            starY[i] = 0;
                            starX[i] = rand.Next(this.ClientSize.Width);
                        }
                    }
                    break;

                case 6: // Хаотичная звезда
                    chaosX += rand.Next(-10, 11);
                    chaosY += rand.Next(-10, 11);

                    if (chaosX < 0) chaosX = this.ClientSize.Width;
                    if (chaosX > this.ClientSize.Width) chaosX = 0;
                    if (chaosY < 0) chaosY = this.ClientSize.Height;
                    if (chaosY > this.ClientSize.Height) chaosY = 0;
                    break;

                case 7: // Ракета
                    if (rocketLaunch)
                    {
                        rocketY -= 5;
                        if (rocketY < -150)
                        {
                            rocketY = this.ClientSize.Height - 150;
                            rocketLaunch = false;
                        }
                    }
                    break;

                case 8: // Броуновское движение
                    brownX += rand.Next(-15, 16);
                    brownY += rand.Next(-15, 16);

                    if (brownX < 0) brownX = this.ClientSize.Width;
                    if (brownX > this.ClientSize.Width) brownX = 0;
                    if (brownY < 0) brownY = this.ClientSize.Height;
                    if (brownY > this.ClientSize.Height) brownY = 0;
                    break;

                case 9: // Часы
                    seconds++;
                    if (seconds >= 60)
                    {
                        seconds = 0;
                        minutes++;
                    }
                    if (minutes >= 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                    if (hours >= 12) hours = 0;
                    break;

                case 10: // Автомобиль
                    carX += 5;
                    if (carX > this.ClientSize.Width)
                        carX = -120;
                    wheelAngle = (wheelAngle + 10) % 360;
                    break;
            }

            this.Invalidate(); // перерисовка
        }

        // ---------- ОТРИСОВКА ----------
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            switch (currentAnimation)
            {
                case 1: DrawSinusoid(g); break;
                case 2: DrawSpiral(g); break;
                case 3: DrawSnowflake(g); break;
                case 4: DrawBall(g); break;
                case 5: DrawStars(g); break;
                case 6: DrawChaoticStar(g); break;
                case 7: DrawRocket(g); break;
                case 8: DrawBrownian(g); break;
                case 9: DrawClock(g); break;
                case 10: DrawCar(g); break;
            }
        }

        // 1. Синусоида
        private void DrawSinusoid(Graphics g)
        {
            // Линия синусоиды
            Pen pen = new Pen(Color.Blue, 1);
            for (int x = 1; x < this.ClientSize.Width; x++)
            {
                double tt = x / 30.0;
                int y1 = this.ClientSize.Height / 2 + (int)(100 * Math.Sin((x - 1) / 30.0));
                int y2 = this.ClientSize.Height / 2 + (int)(100 * Math.Sin(tt));
                g.DrawLine(pen, x - 1, y1, x, y2);
            }

            // Шарик
            g.FillEllipse(Brushes.Red, sinX - 15, sinY - 15, 30, 30);
        }

        // 2. Спираль
        private void DrawSpiral(Graphics g)
        {
            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;

            // Рисуем спираль точками
            Pen pen = new Pen(Color.Green, 1);
            for (double tt = 0; tt < t; tt += 0.1)
            {
                double rr = 3 * tt;
                int xx = cx + (int)(rr * Math.Cos(tt));
                int yy = cy + (int)(rr * Math.Sin(tt));
                g.DrawEllipse(pen, xx, yy, 2, 2);
            }

            // Шарик
            g.FillEllipse(Brushes.Green, spiralX - 10, spiralY - 10, 20, 20);
        }

        // 3. Снежинка
        private void DrawSnowflake(Graphics g)
        {
            // Тело
            g.FillEllipse(Brushes.White, snowX, snowY, 20, 20);

            // Лучики
            Pen pen = new Pen(Color.White, 2);
            g.DrawLine(pen, snowX + 10, snowY + 10, snowX + 25, snowY + 25);
            g.DrawLine(pen, snowX + 10, snowY + 10, snowX - 5, snowY + 25);
            g.DrawLine(pen, snowX + 10, snowY + 10, snowX + 25, snowY - 5);
            g.DrawLine(pen, snowX + 10, snowY + 10, snowX - 5, snowY - 5);
        }

        // 4. Мячик
        private void DrawBall(Graphics g)
        {
            g.FillEllipse(Brushes.Orange, ballX, ballY, 40, 40);
            g.FillEllipse(Brushes.White, ballX + 10, ballY + 10, 8, 8); // блик
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { currentAnimation = 1; ResetPositions(); }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { currentAnimation = 2; ResetPositions(); }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) { currentAnimation = 3; ResetPositions(); }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) { currentAnimation = 4; ResetPositions(); }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) { currentAnimation = 5; ResetPositions(); }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) { currentAnimation = 6; ResetPositions(); }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                currentAnimation = 7; ResetPositions();
                button1.Text = rocketLaunch ? "Стоп" : "Старт";
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked) { currentAnimation = 8; ResetPositions(); }
        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked) { currentAnimation = 9; ResetPositions(); }
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked) { currentAnimation = 10; ResetPositions(); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            timer1.Enabled = !timer1.Enabled;
            button1.Text = timer1.Enabled ? "Стоп" : "Старт";

            // Для ракеты запуск
            if (currentAnimation == 7 && timer1.Enabled)
            {
                rocketLaunch = true;
            }
        }

        // 5. Звезды
        private void DrawStars(Graphics g)
        {
            for (int i = 0; i < 10; i++)
            {
                DrawStar(g, starX[i], starY[i], 10, Brushes.Yellow);
            }
        }

        // 6. Хаотичная звезда
        private void DrawChaoticStar(Graphics g)
        {
            DrawStar(g, chaosX, chaosY, 20, Brushes.Gold);
        }

        // 7. Ракета
        private void DrawRocket(Graphics g)
        {
            int x = this.ClientSize.Width / 2 - 25;

            // Корпус
            g.FillRectangle(Brushes.Silver, x, rocketY, 50, 100);

            // Нос
            Point[] nose = { new Point(x, rocketY), new Point(x + 50, rocketY), new Point(x + 25, rocketY - 30) };
            g.FillPolygon(Brushes.Red, nose);

            // Крылья
            Point[] leftWing = { new Point(x, rocketY + 50), new Point(x - 20, rocketY + 80), new Point(x, rocketY + 80) };
            Point[] rightWing = { new Point(x + 50, rocketY + 50), new Point(x + 70, rocketY + 80), new Point(x + 50, rocketY + 80) };
            g.FillPolygon(Brushes.Blue, leftWing);
            g.FillPolygon(Brushes.Blue, rightWing);

            // Огонь
            if (rocketLaunch)
            {
                Point[] fire = { new Point(x + 15, rocketY + 100), new Point(x + 35, rocketY + 100), new Point(x + 25, rocketY + 140) };
                g.FillPolygon(Brushes.Orange, fire);
            }

            // Иллюминатор
            g.FillEllipse(Brushes.LightBlue, x + 15, rocketY + 30, 20, 20);
        }

        // 8. Броуновское движение
        private void DrawBrownian(Graphics g)
        {
            for (int i = 0; i < 5; i++)
            {
                int alpha = 50 - i * 10;
                Color color = Color.FromArgb(alpha, Color.Purple);
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, brownX - 10 - i * 2, brownY - 10 - i * 2, 20 + i * 4, 20 + i * 4);
            }
            g.FillEllipse(Brushes.Purple, brownX - 8, brownY - 8, 16, 16);
        }

        // 9. Часы
        private void DrawClock(Graphics g)
        {
            int cx = this.ClientSize.Width / 2;
            int cy = this.ClientSize.Height / 2;
            int r = 120;

            // Циферблат
            g.DrawEllipse(new Pen(Color.Black, 3), cx - r, cy - r, r * 2, r * 2);

            // Деления
            for (int i = 0; i < 12; i++)
            {
                double angle = i * 30 * Math.PI / 180;
                int x1 = cx + (int)((r - 10) * Math.Sin(angle));
                int y1 = cy - (int)((r - 10) * Math.Cos(angle));
                int x2 = cx + (int)(r * Math.Sin(angle));
                int y2 = cy - (int)(r * Math.Cos(angle));
                g.DrawLine(new Pen(Color.Black, 2), x1, y1, x2, y2);
            }

            // Стрелки
            double secondAngle = (seconds * 6 - 90) * Math.PI / 180;
            double minuteAngle = (minutes * 6 - 90) * Math.PI / 180;
            double hourAngle = (hours * 30 - 90 + minutes * 0.5) * Math.PI / 180;

            int sx = cx + (int)(r * 0.8 * Math.Cos(secondAngle));
            int sy = cy + (int)(r * 0.8 * Math.Sin(secondAngle));
            int mx = cx + (int)(r * 0.7 * Math.Cos(minuteAngle));
            int my = cy + (int)(r * 0.7 * Math.Sin(minuteAngle));
            int hx = cx + (int)(r * 0.5 * Math.Cos(hourAngle));
            int hy = cy + (int)(r * 0.5 * Math.Sin(hourAngle));

            g.DrawLine(new Pen(Color.Red, 1), cx, cy, sx, sy);
            g.DrawLine(new Pen(Color.Black, 3), cx, cy, mx, my);
            g.DrawLine(new Pen(Color.Black, 5), cx, cy, hx, hy);

            g.FillEllipse(Brushes.Black, cx - 5, cy - 5, 10, 10);
        }

        // 10. Автомобиль
        private void DrawCar(Graphics g)
        {
            // Кузов
            g.FillRectangle(Brushes.Blue, carX, 300, 120, 40);
            g.FillRectangle(Brushes.LightBlue, carX + 20, 280, 80, 30);

            // Окна
            g.FillRectangle(Brushes.LightCyan, carX + 30, 285, 20, 20);
            g.FillRectangle(Brushes.LightCyan, carX + 70, 285, 20, 20);

            // Колеса
            DrawWheel(g, carX + 20, 340, wheelAngle);
            DrawWheel(g, carX + 90, 340, wheelAngle);
        }

        private void DrawWheel(Graphics g, int x, int y, int angle)
        {
            g.FillEllipse(Brushes.Black, x, y, 25, 25);

            for (int i = 0; i < 4; i++)
            {
                double a = (angle + i * 90) * Math.PI / 180;
                int x1 = x + 12 + (int)(10 * Math.Cos(a));
                int y1 = y + 12 + (int)(10 * Math.Sin(a));
                int x2 = x + 12 - (int)(10 * Math.Cos(a));
                int y2 = y + 12 - (int)(10 * Math.Sin(a));
                g.DrawLine(new Pen(Color.White, 2), x1, y1, x2, y2);
            }
        }

        // Рисование звезды
        private void DrawStar(Graphics g, int x, int y, int size, Brush brush)
        {
            PointF[] points = new PointF[10];
            for (int i = 0; i < 10; i++)
            {
                double angle = i * Math.PI / 5 - Math.PI / 2;
                double r = (i % 2 == 0) ? size : size / 2;
                points[i] = new PointF(x + (float)(r * Math.Cos(angle)), y + (float)(r * Math.Sin(angle)));
            }
            g.FillPolygon(brush, points);
        }

        // ---------- СОБЫТИЯ КНОПОК ----------
        

       
    }
}