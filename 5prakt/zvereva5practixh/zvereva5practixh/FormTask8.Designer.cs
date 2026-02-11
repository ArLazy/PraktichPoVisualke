namespace zvereva5practixh
{
    partial class FormTask8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewResultRow = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMaxDiagonal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultRow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(599, 26);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(450, 458);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // dataGridViewResultRow
            // 
            this.dataGridViewResultRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultRow.Location = new System.Drawing.Point(32, 40);
            this.dataGridViewResultRow.Name = "dataGridViewResultRow";
            this.dataGridViewResultRow.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultRow.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMaxDiagonal
            // 
            this.textBoxMaxDiagonal.Location = new System.Drawing.Point(32, 269);
            this.textBoxMaxDiagonal.Name = "textBoxMaxDiagonal";
            this.textBoxMaxDiagonal.Size = new System.Drawing.Size(130, 20);
            this.textBoxMaxDiagonal.TabIndex = 3;
            // 
            // FormTask8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 556);
            this.Controls.Add(this.textBoxMaxDiagonal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewResultRow);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Name = "FormTask8";
            this.Text = "Задание 8 Вариант 13";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewResultRow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMaxDiagonal;
    }
}