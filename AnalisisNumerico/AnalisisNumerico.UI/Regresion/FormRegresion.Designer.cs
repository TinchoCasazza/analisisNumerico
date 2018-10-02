namespace AnalisisNumerico.UI
{
    partial class FormRegresion
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
            this.textBox_cantPares = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.label_Recta = new System.Windows.Forms.Label();
            this.textBox_Recta = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de pares:";
            // 
            // textBox_cantPares
            // 
            this.textBox_cantPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cantPares.Location = new System.Drawing.Point(239, 56);
            this.textBox_cantPares.Name = "textBox_cantPares";
            this.textBox_cantPares.Size = new System.Drawing.Size(116, 30);
            this.textBox_cantPares.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(73, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(459, 427);
            this.dataGridView1.TabIndex = 2;
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
            this.button_Confirmar.Location = new System.Drawing.Point(426, 53);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(129, 36);
            this.button_Confirmar.TabIndex = 3;
            this.button_Confirmar.Text = "Confirmar";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // label_Recta
            // 
            this.label_Recta.AutoSize = true;
            this.label_Recta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Recta.Location = new System.Drawing.Point(602, 305);
            this.label_Recta.Name = "label_Recta";
            this.label_Recta.Size = new System.Drawing.Size(68, 25);
            this.label_Recta.TabIndex = 4;
            this.label_Recta.Text = "Recta:";
            // 
            // textBox_Recta
            // 
            this.textBox_Recta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Recta.Location = new System.Drawing.Point(676, 302);
            this.textBox_Recta.Name = "textBox_Recta";
            this.textBox_Recta.Size = new System.Drawing.Size(344, 30);
            this.textBox_Recta.TabIndex = 5;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(720, 189);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(199, 49);
            this.button_Calcular.TabIndex = 6;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpiar.Location = new System.Drawing.Point(743, 443);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(160, 38);
            this.button_Limpiar.TabIndex = 7;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // FormRegresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1073, 588);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_Recta);
            this.Controls.Add(this.label_Recta);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_cantPares);
            this.Controls.Add(this.label1);
            this.Name = "FormRegresion";
            this.Text = "FormRegresion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cantPares;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.Label label_Recta;
        private System.Windows.Forms.TextBox textBox_Recta;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Button button_Limpiar;
    }
}