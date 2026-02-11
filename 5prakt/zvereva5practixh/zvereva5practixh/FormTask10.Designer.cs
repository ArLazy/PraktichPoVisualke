namespace zvereva5practixh
{
    partial class FormTask10
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
            this.dataGridViewColumnSums = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumnSums)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(337, 30);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(877, 398);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // dataGridViewColumnSums
            // 
            this.dataGridViewColumnSums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumnSums.Location = new System.Drawing.Point(48, 30);
            this.dataGridViewColumnSums.Name = "dataGridViewColumnSums";
            this.dataGridViewColumnSums.Size = new System.Drawing.Size(201, 211);
            this.dataGridViewColumnSums.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTask10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewColumnSums);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Name = "FormTask10";
            this.Text = "Задание 10 Вариант 15";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumnSums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewColumnSums;
        private System.Windows.Forms.Button button1;
    }
}