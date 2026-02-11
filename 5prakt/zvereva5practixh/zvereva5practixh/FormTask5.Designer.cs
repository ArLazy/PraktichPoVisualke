namespace zvereva5practixh
{
    partial class FormTask5
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
            this.textBoxMaxElement = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(53, 31);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(499, 150);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // textBoxMaxElement
            // 
            this.textBoxMaxElement.Location = new System.Drawing.Point(53, 210);
            this.textBoxMaxElement.Name = "textBoxMaxElement";
            this.textBoxMaxElement.Size = new System.Drawing.Size(240, 20);
            this.textBoxMaxElement.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTask5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMaxElement);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Name = "FormTask5";
            this.Text = "Задание 5 Вариант 5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.TextBox textBoxMaxElement;
        private System.Windows.Forms.Button button1;
    }
}