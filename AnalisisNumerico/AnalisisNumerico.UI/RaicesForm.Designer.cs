namespace AnalisisNumerico.UI
{
    partial class RaicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaicesForm));
            this.label_Iteraciones = new System.Windows.Forms.Label();
            this.label_Tolerancia = new System.Windows.Forms.Label();
            this.label_ValorInicial = new System.Windows.Forms.Label();
            this.label_ValorFinal = new System.Windows.Forms.Label();
            this.label_Funcion = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.textBox_Iteraciones = new System.Windows.Forms.TextBox();
            this.textBox_Tolerancia = new System.Windows.Forms.TextBox();
            this.textBox_ValorInical = new System.Windows.Forms.TextBox();
            this.textBox_ValorFinal = new System.Windows.Forms.TextBox();
            this.label_Raiz = new System.Windows.Forms.Label();
            this.textBox_MostrarRaiz = new System.Windows.Forms.TextBox();
            this.label_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MostrarIteraciones = new System.Windows.Forms.TextBox();
            this.textBox_MostrarError = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.textBox_Funcion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Iteraciones
            // 
            this.label_Iteraciones.AutoSize = true;
            this.label_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Iteraciones.Location = new System.Drawing.Point(19, 127);
            this.label_Iteraciones.Name = "label_Iteraciones";
            this.label_Iteraciones.Size = new System.Drawing.Size(149, 29);
            this.label_Iteraciones.TabIndex = 1;
            this.label_Iteraciones.Text = "Iteracciones:";
            // 
            // label_Tolerancia
            // 
            this.label_Tolerancia.AutoSize = true;
            this.label_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tolerancia.Location = new System.Drawing.Point(357, 129);
            this.label_Tolerancia.Name = "label_Tolerancia";
            this.label_Tolerancia.Size = new System.Drawing.Size(134, 29);
            this.label_Tolerancia.TabIndex = 2;
            this.label_Tolerancia.Text = "Tolerancia:";
            // 
            // label_ValorInicial
            // 
            this.label_ValorInicial.AutoSize = true;
            this.label_ValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorInicial.Location = new System.Drawing.Point(17, 228);
            this.label_ValorInicial.Name = "label_ValorInicial";
            this.label_ValorInicial.Size = new System.Drawing.Size(143, 29);
            this.label_ValorInicial.TabIndex = 3;
            this.label_ValorInicial.Text = "Valor inicial:";
            // 
            // label_ValorFinal
            // 
            this.label_ValorFinal.AutoSize = true;
            this.label_ValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorFinal.Location = new System.Drawing.Point(365, 230);
            this.label_ValorFinal.Name = "label_ValorFinal";
            this.label_ValorFinal.Size = new System.Drawing.Size(125, 29);
            this.label_ValorFinal.TabIndex = 4;
            this.label_ValorFinal.Text = "Valor final:";
            this.label_ValorFinal.Click += new System.EventHandler(this.label_ValorFinal_Click);
            // 
            // label_Funcion
            // 
            this.label_Funcion.AutoSize = true;
            this.label_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcion.Location = new System.Drawing.Point(22, 39);
            this.label_Funcion.Name = "label_Funcion";
            this.label_Funcion.Size = new System.Drawing.Size(105, 29);
            this.label_Funcion.TabIndex = 5;
            this.label_Funcion.Text = "Función:";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(17, 458);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(122, 29);
            this.label_Resultado.TabIndex = 6;
            this.label_Resultado.Text = "Resultado";
            // 
            // textBox_Iteraciones
            // 
            this.textBox_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Iteraciones.Location = new System.Drawing.Point(168, 127);
            this.textBox_Iteraciones.Name = "textBox_Iteraciones";
            this.textBox_Iteraciones.Size = new System.Drawing.Size(147, 34);
            this.textBox_Iteraciones.TabIndex = 7;
            this.textBox_Iteraciones.TextChanged += new System.EventHandler(this.textBox_Iteraciones_TextChanged);
            this.textBox_Iteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Iteraciones_KeyPress);
            // 
            // textBox_Tolerancia
            // 
            this.textBox_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tolerancia.Location = new System.Drawing.Point(497, 129);
            this.textBox_Tolerancia.Name = "textBox_Tolerancia";
            this.textBox_Tolerancia.Size = new System.Drawing.Size(219, 34);
            this.textBox_Tolerancia.TabIndex = 8;
            this.textBox_Tolerancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Tolerancia_KeyPress);
            // 
            // textBox_ValorInical
            // 
            this.textBox_ValorInical.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorInical.Location = new System.Drawing.Point(166, 227);
            this.textBox_ValorInical.Name = "textBox_ValorInical";
            this.textBox_ValorInical.Size = new System.Drawing.Size(167, 34);
            this.textBox_ValorInical.TabIndex = 9;
            this.textBox_ValorInical.TextChanged += new System.EventHandler(this.textBox_ValorInical_TextChanged);
            this.textBox_ValorInical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ValorInical_KeyPress);
            // 
            // textBox_ValorFinal
            // 
            this.textBox_ValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorFinal.Location = new System.Drawing.Point(498, 227);
            this.textBox_ValorFinal.Name = "textBox_ValorFinal";
            this.textBox_ValorFinal.Size = new System.Drawing.Size(168, 34);
            this.textBox_ValorFinal.TabIndex = 10;
            this.textBox_ValorFinal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox_ValorFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ValorFinal_KeyPress);
            // 
            // label_Raiz
            // 
            this.label_Raiz.AutoSize = true;
            this.label_Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Raiz.Location = new System.Drawing.Point(77, 514);
            this.label_Raiz.Name = "label_Raiz";
            this.label_Raiz.Size = new System.Drawing.Size(66, 29);
            this.label_Raiz.TabIndex = 11;
            this.label_Raiz.Text = "Raíz:";
            // 
            // textBox_MostrarRaiz
            // 
            this.textBox_MostrarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MostrarRaiz.Location = new System.Drawing.Point(149, 509);
            this.textBox_MostrarRaiz.Name = "textBox_MostrarRaiz";
            this.textBox_MostrarRaiz.Size = new System.Drawing.Size(173, 34);
            this.textBox_MostrarRaiz.TabIndex = 12;
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_.Location = new System.Drawing.Point(333, 513);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(137, 29);
            this.label_.TabIndex = 13;
            this.label_.Text = "iteraciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Error:";
            // 
            // textBox_MostrarIteraciones
            // 
            this.textBox_MostrarIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MostrarIteraciones.Location = new System.Drawing.Point(476, 513);
            this.textBox_MostrarIteraciones.Name = "textBox_MostrarIteraciones";
            this.textBox_MostrarIteraciones.Size = new System.Drawing.Size(198, 34);
            this.textBox_MostrarIteraciones.TabIndex = 15;
            // 
            // textBox_MostrarError
            // 
            this.textBox_MostrarError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MostrarError.Location = new System.Drawing.Point(770, 513);
            this.textBox_MostrarError.Name = "textBox_MostrarError";
            this.textBox_MostrarError.Size = new System.Drawing.Size(253, 34);
            this.textBox_MostrarError.TabIndex = 16;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(27, 333);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(184, 49);
            this.button_Calcular.TabIndex = 17;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // textBox_Funcion
            // 
            this.textBox_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Funcion.Location = new System.Drawing.Point(130, 36);
            this.textBox_Funcion.Name = "textBox_Funcion";
            this.textBox_Funcion.Size = new System.Drawing.Size(205, 34);
            this.textBox_Funcion.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(770, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // RaicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1364, 616);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Funcion);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_MostrarError);
            this.Controls.Add(this.textBox_MostrarIteraciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_);
            this.Controls.Add(this.textBox_MostrarRaiz);
            this.Controls.Add(this.label_Raiz);
            this.Controls.Add(this.textBox_ValorFinal);
            this.Controls.Add(this.textBox_ValorInical);
            this.Controls.Add(this.textBox_Tolerancia);
            this.Controls.Add(this.textBox_Iteraciones);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label_Funcion);
            this.Controls.Add(this.label_ValorFinal);
            this.Controls.Add(this.label_ValorInicial);
            this.Controls.Add(this.label_Tolerancia);
            this.Controls.Add(this.label_Iteraciones);
            this.Name = "RaicesForm";
            this.Text = "RaicesForm";
            this.Load += new System.EventHandler(this.RaicesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Iteraciones;
        private System.Windows.Forms.Label label_Tolerancia;
        private System.Windows.Forms.Label label_ValorInicial;
        private System.Windows.Forms.Label label_ValorFinal;
        private System.Windows.Forms.Label label_Funcion;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.TextBox textBox_Iteraciones;
        private System.Windows.Forms.TextBox textBox_Tolerancia;
        private System.Windows.Forms.TextBox textBox_ValorInical;
        private System.Windows.Forms.TextBox textBox_ValorFinal;
        private System.Windows.Forms.Label label_Raiz;
        private System.Windows.Forms.TextBox textBox_MostrarRaiz;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MostrarIteraciones;
        private System.Windows.Forms.TextBox textBox_MostrarError;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.TextBox textBox_Funcion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}