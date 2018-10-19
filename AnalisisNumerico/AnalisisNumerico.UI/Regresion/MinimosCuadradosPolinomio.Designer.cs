namespace AnalisisNumerico.UI
{
    partial class MinimosCuadradosPolinomio
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CantidadPares = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Grado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label_Efectivi = new System.Windows.Forms.Label();
            this.textBoxEfectividad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Gradfinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Error = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de pares:";
            // 
            // textBox_CantidadPares
            // 
            this.textBox_CantidadPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CantidadPares.Location = new System.Drawing.Point(209, 55);
            this.textBox_CantidadPares.Name = "textBox_CantidadPares";
            this.textBox_CantidadPares.Size = new System.Drawing.Size(155, 30);
            this.textBox_CantidadPares.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grado:";
            // 
            // textBox_Grado
            // 
            this.textBox_Grado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Grado.Location = new System.Drawing.Point(209, 105);
            this.textBox_Grado.Name = "textBox_Grado";
            this.textBox_Grado.Size = new System.Drawing.Size(100, 30);
            this.textBox_Grado.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(64, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(377, 358);
            this.dataGridView1.TabIndex = 4;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Y";
            this.Column1.Name = "Column1";
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(667, 55);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(144, 43);
            this.button_Calcular.TabIndex = 5;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(615, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(252, 343);
            this.dataGridView2.TabIndex = 7;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Resultados";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpiar.Location = new System.Drawing.Point(945, 493);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(124, 46);
            this.button_Limpiar.TabIndex = 8;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(412, 51);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(79, 38);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label_Efectivi
            // 
            this.label_Efectivi.AutoSize = true;
            this.label_Efectivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Efectivi.Location = new System.Drawing.Point(962, 196);
            this.label_Efectivi.Name = "label_Efectivi";
            this.label_Efectivi.Size = new System.Drawing.Size(107, 25);
            this.label_Efectivi.TabIndex = 10;
            this.label_Efectivi.Text = "Efectividad";
            // 
            // textBoxEfectividad
            // 
            this.textBoxEfectividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEfectividad.Location = new System.Drawing.Point(945, 224);
            this.textBoxEfectividad.Name = "textBoxEfectividad";
            this.textBoxEfectividad.Size = new System.Drawing.Size(163, 30);
            this.textBoxEfectividad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(945, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grado final";
            // 
            // textBox_Gradfinal
            // 
            this.textBox_Gradfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Gradfinal.Location = new System.Drawing.Point(950, 321);
            this.textBox_Gradfinal.Name = "textBox_Gradfinal";
            this.textBox_Gradfinal.Size = new System.Drawing.Size(100, 30);
            this.textBox_Gradfinal.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Error:";
            // 
            // textBox_Error
            // 
            this.textBox_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Error.Location = new System.Drawing.Point(209, 150);
            this.textBox_Error.Name = "textBox_Error";
            this.textBox_Error.Size = new System.Drawing.Size(100, 30);
            this.textBox_Error.TabIndex = 15;
            // 
            // MinimosCuadradosPolinomio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1142, 566);
            this.Controls.Add(this.textBox_Error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Gradfinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEfectividad);
            this.Controls.Add(this.label_Efectivi);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Grado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CantidadPares);
            this.Controls.Add(this.label1);
            this.Name = "MinimosCuadradosPolinomio";
            this.Text = "MinimosCuadradosPolinomio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CantidadPares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Grado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label_Efectivi;
        private System.Windows.Forms.TextBox textBoxEfectividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Gradfinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Error;
    }
}