namespace practich7Zvereva
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColor = new System.Windows.Forms.Button();
            this.nudPenWidth = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRandomPoints = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.btnSelectChannel = new System.Windows.Forms.Button();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.Обрезать = new System.Windows.Forms.Button();
            this.nudTriangleSide = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.nudRhombusSize = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHorizlines = new System.Windows.Forms.Button();
            this.btnVertiLines = new System.Windows.Forms.Button();
            this.btnSplitChannels = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriangleSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRhombusSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(258, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(117, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Выбрать цвет";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // nudPenWidth
            // 
            this.nudPenWidth.Location = new System.Drawing.Point(381, 12);
            this.nudPenWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPenWidth.Name = "nudPenWidth";
            this.nudPenWidth.Size = new System.Drawing.Size(120, 20);
            this.nudPenWidth.TabIndex = 1;
            this.nudPenWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPenWidth.ValueChanged += new System.EventHandler(this.nudPenWidth_ValueChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(135, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(117, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(52, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 431);
            this.panel1.TabIndex = 5;
            // 
            // btnRandomPoints
            // 
            this.btnRandomPoints.Location = new System.Drawing.Point(507, 12);
            this.btnRandomPoints.Name = "btnRandomPoints";
            this.btnRandomPoints.Size = new System.Drawing.Size(117, 23);
            this.btnRandomPoints.TabIndex = 6;
            this.btnRandomPoints.Text = "1000 точек";
            this.btnRandomPoints.UseVisualStyleBackColor = true;
            this.btnRandomPoints.Click += new System.EventHandler(this.btnRandomPoints_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(630, 12);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(117, 23);
            this.btnGrayscale.TabIndex = 7;
            this.btnGrayscale.Text = "Черно-белый";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(381, 49);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(70, 17);
            this.rbRed.TabIndex = 8;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Красный";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(472, 49);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(70, 17);
            this.rbGreen.TabIndex = 9;
            this.rbGreen.Text = "Зелёный";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(563, 49);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(56, 17);
            this.rbBlue.TabIndex = 10;
            this.rbBlue.Text = "Синий";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // btnSelectChannel
            // 
            this.btnSelectChannel.Location = new System.Drawing.Point(630, 49);
            this.btnSelectChannel.Name = "btnSelectChannel";
            this.btnSelectChannel.Size = new System.Drawing.Size(117, 23);
            this.btnSelectChannel.TabIndex = 11;
            this.btnSelectChannel.Text = "Оставить только";
            this.btnSelectChannel.UseVisualStyleBackColor = true;
            this.btnSelectChannel.Click += new System.EventHandler(this.btnSelectChannel_Click);
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(12, 46);
            this.nudRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRadius.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 20);
            this.nudRadius.TabIndex = 12;
            this.nudRadius.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Обрезать
            // 
            this.Обрезать.Location = new System.Drawing.Point(138, 41);
            this.Обрезать.Name = "Обрезать";
            this.Обрезать.Size = new System.Drawing.Size(83, 23);
            this.Обрезать.TabIndex = 13;
            this.Обрезать.Text = "Круг";
            this.Обрезать.UseVisualStyleBackColor = true;
            this.Обрезать.Click += new System.EventHandler(this.Обрезать_Click);
            // 
            // nudTriangleSide
            // 
            this.nudTriangleSide.Location = new System.Drawing.Point(12, 72);
            this.nudTriangleSide.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nudTriangleSide.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTriangleSide.Name = "nudTriangleSide";
            this.nudTriangleSide.Size = new System.Drawing.Size(120, 20);
            this.nudTriangleSide.TabIndex = 14;
            this.nudTriangleSide.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Треугольник";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudRhombusSize
            // 
            this.nudRhombusSize.Location = new System.Drawing.Point(12, 98);
            this.nudRhombusSize.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudRhombusSize.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudRhombusSize.Name = "nudRhombusSize";
            this.nudRhombusSize.Size = new System.Drawing.Size(120, 20);
            this.nudRhombusSize.TabIndex = 16;
            this.nudRhombusSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ромб";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHorizlines
            // 
            this.btnHorizlines.Location = new System.Drawing.Point(258, 46);
            this.btnHorizlines.Name = "btnHorizlines";
            this.btnHorizlines.Size = new System.Drawing.Size(117, 23);
            this.btnHorizlines.TabIndex = 18;
            this.btnHorizlines.Text = "Горизонты";
            this.btnHorizlines.UseVisualStyleBackColor = true;
            this.btnHorizlines.Click += new System.EventHandler(this.btnHorizlines_Click);
            // 
            // btnVertiLines
            // 
            this.btnVertiLines.Location = new System.Drawing.Point(258, 75);
            this.btnVertiLines.Name = "btnVertiLines";
            this.btnVertiLines.Size = new System.Drawing.Size(117, 23);
            this.btnVertiLines.TabIndex = 19;
            this.btnVertiLines.Text = "Вертикалы";
            this.btnVertiLines.UseVisualStyleBackColor = true;
            this.btnVertiLines.Click += new System.EventHandler(this.btnVertiLines_Click);
            // 
            // btnSplitChannels
            // 
            this.btnSplitChannels.Location = new System.Drawing.Point(22, 124);
            this.btnSplitChannels.Name = "btnSplitChannels";
            this.btnSplitChannels.Size = new System.Drawing.Size(75, 23);
            this.btnSplitChannels.TabIndex = 20;
            this.btnSplitChannels.Text = "4 части";
            this.btnSplitChannels.UseVisualStyleBackColor = true;
            this.btnSplitChannels.Click += new System.EventHandler(this.btnSplitChannels_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Синий в красный";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Негатив (градации серого)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 636);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSplitChannels);
            this.Controls.Add(this.btnVertiLines);
            this.Controls.Add(this.btnHorizlines);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nudRhombusSize);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudTriangleSide);
            this.Controls.Add(this.Обрезать);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.btnSelectChannel);
            this.Controls.Add(this.rbBlue);
            this.Controls.Add(this.rbGreen);
            this.Controls.Add(this.rbRed);
            this.Controls.Add(this.btnGrayscale);
            this.Controls.Add(this.btnRandomPoints);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.nudPenWidth);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTriangleSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRhombusSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown nudPenWidth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRandomPoints;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.Button btnSelectChannel;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Button Обрезать;
        private System.Windows.Forms.NumericUpDown nudTriangleSide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudRhombusSize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHorizlines;
        private System.Windows.Forms.Button btnVertiLines;
        private System.Windows.Forms.Button btnSplitChannels;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

