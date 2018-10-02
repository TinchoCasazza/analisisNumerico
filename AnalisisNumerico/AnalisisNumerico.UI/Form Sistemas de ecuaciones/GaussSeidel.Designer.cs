namespace AnalisisNumerico.UI
{
    partial class GaussSeidel
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
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.textBox_Numincorgnitas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Tolerancia = new System.Windows.Forms.Label();
            this.textBox_Tolerancia = new System.Windows.Forms.TextBox();
            this.button_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero incognitas:";
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirmar.Location = new System.Drawing.Point(416, 47);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(129, 35);
            this.button_Confirmar.TabIndex = 1;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // textBox_Numincorgnitas
            // 
            this.textBox_Numincorgnitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Numincorgnitas.Location = new System.Drawing.Point(239, 49);
            this.textBox_Numincorgnitas.Name = "textBox_Numincorgnitas";
            this.textBox_Numincorgnitas.Size = new System.Drawing.Size(121, 30);
            this.textBox_Numincorgnitas.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(859, 49);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(153, 35);
            this.button_Calcular.TabIndex = 4;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(859, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(249, 353);
            this.dataGridView2.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Resultados";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // label_Tolerancia
            // 
            this.label_Tolerancia.AutoSize = true;
            this.label_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tolerancia.Location = new System.Drawing.Point(58, 105);
            this.label_Tolerancia.Name = "label_Tolerancia";
            this.label_Tolerancia.Size = new System.Drawing.Size(110, 25);
            this.label_Tolerancia.TabIndex = 6;
            this.label_Tolerancia.Text = "Tolerancia:";
            // 
            // textBox_Tolerancia
            // 
            this.textBox_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tolerancia.Location = new System.Drawing.Point(178, 107);
            this.textBox_Tolerancia.Name = "textBox_Tolerancia";
            this.textBox_Tolerancia.Size = new System.Drawing.Size(116, 30);
            this.textBox_Tolerancia.TabIndex = 7;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.Location = new System.Drawing.Point(904, 526);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(152, 38);
            this.button_limpiar.TabIndex = 8;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // GaussSeidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1132, 576);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.textBox_Tolerancia);
            this.Controls.Add(this.label_Tolerancia);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Numincorgnitas);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.label1);
            this.Name = "GaussSeidel";
            this.Text = "GaussSeidel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.TextBox textBox_Numincorgnitas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_Tolerancia;
        private System.Windows.Forms.TextBox textBox_Tolerancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button_limpiar;
    }
}