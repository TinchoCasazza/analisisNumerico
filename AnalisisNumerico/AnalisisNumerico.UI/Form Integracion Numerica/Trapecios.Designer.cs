namespace AnalisisNumerico.UI
{
    partial class Trapecios
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
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_TMultiple = new System.Windows.Forms.Button();
            this.textBox_Funcion = new System.Windows.Forms.TextBox();
            this.button_Trapecio = new System.Windows.Forms.Button();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.label_Funcion = new System.Windows.Forms.Label();
            this.label_ValorFinal = new System.Windows.Forms.Label();
            this.label_ValorInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Resultado.Location = new System.Drawing.Point(127, 281);
            this.textBox_Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.Size = new System.Drawing.Size(188, 28);
            this.textBox_Resultado.TabIndex = 52;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_n.Location = new System.Drawing.Point(273, 115);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(126, 28);
            this.textBox_n.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "n (solo trapecio multiple):";
            // 
            // button_TMultiple
            // 
            this.button_TMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TMultiple.Location = new System.Drawing.Point(238, 173);
            this.button_TMultiple.Margin = new System.Windows.Forms.Padding(2);
            this.button_TMultiple.Name = "button_TMultiple";
            this.button_TMultiple.Size = new System.Drawing.Size(172, 52);
            this.button_TMultiple.TabIndex = 49;
            this.button_TMultiple.Text = "Trapecio Multiple";
            this.button_TMultiple.UseVisualStyleBackColor = true;
            this.button_TMultiple.Click += new System.EventHandler(this.Button_TMultiple_Click_1);
            // 
            // textBox_Funcion
            // 
            this.textBox_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Funcion.Location = new System.Drawing.Point(147, 11);
            this.textBox_Funcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Funcion.Name = "textBox_Funcion";
            this.textBox_Funcion.Size = new System.Drawing.Size(185, 28);
            this.textBox_Funcion.TabIndex = 48;
            // 
            // button_Trapecio
            // 
            this.button_Trapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Trapecio.Location = new System.Drawing.Point(55, 173);
            this.button_Trapecio.Margin = new System.Windows.Forms.Padding(2);
            this.button_Trapecio.Name = "button_Trapecio";
            this.button_Trapecio.Size = new System.Drawing.Size(147, 52);
            this.button_Trapecio.TabIndex = 47;
            this.button_Trapecio.Text = "Trapecio";
            this.button_Trapecio.UseVisualStyleBackColor = true;
            this.button_Trapecio.Click += new System.EventHandler(this.Button_Trapecio_Click_1);
            // 
            // textBox_b
            // 
            this.textBox_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_b.Location = new System.Drawing.Point(273, 69);
            this.textBox_b.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(127, 28);
            this.textBox_b.TabIndex = 46;
            // 
            // textBox_a
            // 
            this.textBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_a.Location = new System.Drawing.Point(74, 69);
            this.textBox_a.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(126, 28);
            this.textBox_a.TabIndex = 45;
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(173, 241);
            this.label_Resultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(94, 24);
            this.label_Resultado.TabIndex = 44;
            this.label_Resultado.Text = "Resultado";
            // 
            // label_Funcion
            // 
            this.label_Funcion.AutoSize = true;
            this.label_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcion.Location = new System.Drawing.Point(65, 14);
            this.label_Funcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Funcion.Name = "label_Funcion";
            this.label_Funcion.Size = new System.Drawing.Size(85, 24);
            this.label_Funcion.TabIndex = 43;
            this.label_Funcion.Text = "Función:";
            // 
            // label_ValorFinal
            // 
            this.label_ValorFinal.AutoSize = true;
            this.label_ValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorFinal.Location = new System.Drawing.Point(228, 72);
            this.label_ValorFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ValorFinal.Name = "label_ValorFinal";
            this.label_ValorFinal.Size = new System.Drawing.Size(26, 24);
            this.label_ValorFinal.TabIndex = 42;
            this.label_ValorFinal.Text = "b:";
            // 
            // label_ValorInicial
            // 
            this.label_ValorInicial.AutoSize = true;
            this.label_ValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorInicial.Location = new System.Drawing.Point(30, 72);
            this.label_ValorInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ValorInicial.Name = "label_ValorInicial";
            this.label_ValorInicial.Size = new System.Drawing.Size(25, 24);
            this.label_ValorInicial.TabIndex = 41;
            this.label_ValorInicial.Text = "a:";
            // 
            // Trapecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(444, 330);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_TMultiple);
            this.Controls.Add(this.textBox_Funcion);
            this.Controls.Add(this.button_Trapecio);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label_Funcion);
            this.Controls.Add(this.label_ValorFinal);
            this.Controls.Add(this.label_ValorInicial);
            this.Name = "Trapecios";
            this.Text = "Trapecios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_TMultiple;
        private System.Windows.Forms.TextBox textBox_Funcion;
        private System.Windows.Forms.Button button_Trapecio;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Label label_Funcion;
        private System.Windows.Forms.Label label_ValorFinal;
        private System.Windows.Forms.Label label_ValorInicial;
    }
}