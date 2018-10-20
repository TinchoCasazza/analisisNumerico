namespace AnalisisNumerico.UI.Regresion
{
    partial class FormLagranje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.textBox_cantPares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.label_Recta = new System.Windows.Forms.Label();
            this.textBox_Interpolacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_valX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(28, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 356);
            this.dataGridView1.TabIndex = 3;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Y";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirmar.Location = new System.Drawing.Point(28, 50);
            this.button_Confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(344, 27);
            this.button_Confirmar.TabIndex = 6;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // textBox_cantPares
            // 
            this.textBox_cantPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cantPares.Location = new System.Drawing.Point(171, 9);
            this.textBox_cantPares.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cantPares.Name = "textBox_cantPares";
            this.textBox_cantPares.Size = new System.Drawing.Size(55, 26);
            this.textBox_cantPares.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de pares:";
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(28, 441);
            this.button_Calcular.Margin = new System.Windows.Forms.Padding(2);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(344, 27);
            this.button_Calcular.TabIndex = 7;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // label_Recta
            // 
            this.label_Recta.AutoSize = true;
            this.label_Recta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Recta.ForeColor = System.Drawing.Color.White;
            this.label_Recta.Location = new System.Drawing.Point(24, 483);
            this.label_Recta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Recta.Name = "label_Recta";
            this.label_Recta.Size = new System.Drawing.Size(105, 20);
            this.label_Recta.TabIndex = 8;
            this.label_Recta.Text = "Interpolacion:";
            // 
            // textBox_Interpolacion
            // 
            this.textBox_Interpolacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Interpolacion.Location = new System.Drawing.Point(133, 480);
            this.textBox_Interpolacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Interpolacion.Name = "textBox_Interpolacion";
            this.textBox_Interpolacion.Size = new System.Drawing.Size(89, 26);
            this.textBox_Interpolacion.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor X:";
            // 
            // textBox_valX
            // 
            this.textBox_valX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_valX.Location = new System.Drawing.Point(317, 9);
            this.textBox_valX.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_valX.Name = "textBox_valX";
            this.textBox_valX.Size = new System.Drawing.Size(55, 26);
            this.textBox_valX.TabIndex = 11;
            // 
            // Lagranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(397, 526);
            this.Controls.Add(this.textBox_valX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Interpolacion);
            this.Controls.Add(this.label_Recta);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.textBox_cantPares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lagranje";
            this.Text = "Lagranje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.TextBox textBox_cantPares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Label label_Recta;
        private System.Windows.Forms.TextBox textBox_Interpolacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_valX;
    }
}