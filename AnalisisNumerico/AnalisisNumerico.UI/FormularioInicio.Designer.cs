namespace AnalisisNumerico.UI
{
    partial class FormularioInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Funcion = new System.Windows.Forms.Label();
            this.textBox_Funcion = new System.Windows.Forms.TextBox();
            this.label_iteraciones = new System.Windows.Forms.Label();
            this.label_Tolerancia = new System.Windows.Forms.Label();
            this.label_InicioIntervalo = new System.Windows.Forms.Label();
            this.label_FinIntervalo = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.textBox_Iteraciones = new System.Windows.Forms.TextBox();
            this.textBox_Tolerancia = new System.Windows.Forms.TextBox();
            this.textBox_InicioIntervalo = new System.Windows.Forms.TextBox();
            this.textBox_FinIntervalo = new System.Windows.Forms.TextBox();
            this.label_MostrarResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Funcion
            // 
            this.label_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcion.Location = new System.Drawing.Point(12, 43);
            this.label_Funcion.Name = "label_Funcion";
            this.label_Funcion.Size = new System.Drawing.Size(113, 29);
            this.label_Funcion.TabIndex = 0;
            this.label_Funcion.Text = "Función:";
            // 
            // textBox_Funcion
            // 
            this.textBox_Funcion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Funcion.Location = new System.Drawing.Point(125, 43);
            this.textBox_Funcion.Name = "textBox_Funcion";
            this.textBox_Funcion.Size = new System.Drawing.Size(137, 34);
            this.textBox_Funcion.TabIndex = 1;
            // 
            // label_iteraciones
            // 
            this.label_iteraciones.AutoSize = true;
            this.label_iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iteraciones.Location = new System.Drawing.Point(318, 44);
            this.label_iteraciones.Name = "label_iteraciones";
            this.label_iteraciones.Size = new System.Drawing.Size(137, 29);
            this.label_iteraciones.TabIndex = 2;
            this.label_iteraciones.Text = "Iteraciones:";
            // 
            // label_Tolerancia
            // 
            this.label_Tolerancia.AutoSize = true;
            this.label_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tolerancia.Location = new System.Drawing.Point(644, 43);
            this.label_Tolerancia.Name = "label_Tolerancia";
            this.label_Tolerancia.Size = new System.Drawing.Size(134, 29);
            this.label_Tolerancia.TabIndex = 3;
            this.label_Tolerancia.Text = "Tolerancia:";
            // 
            // label_InicioIntervalo
            // 
            this.label_InicioIntervalo.AutoSize = true;
            this.label_InicioIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InicioIntervalo.Location = new System.Drawing.Point(185, 145);
            this.label_InicioIntervalo.Name = "label_InicioIntervalo";
            this.label_InicioIntervalo.Size = new System.Drawing.Size(173, 29);
            this.label_InicioIntervalo.TabIndex = 4;
            this.label_InicioIntervalo.Text = "Inicio intervalo:";
            // 
            // label_FinIntervalo
            // 
            this.label_FinIntervalo.AutoSize = true;
            this.label_FinIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FinIntervalo.Location = new System.Drawing.Point(534, 145);
            this.label_FinIntervalo.Name = "label_FinIntervalo";
            this.label_FinIntervalo.Size = new System.Drawing.Size(150, 29);
            this.label_FinIntervalo.TabIndex = 5;
            this.label_FinIntervalo.Text = "Fin intervalo:";
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(375, 282);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(128, 29);
            this.label_Resultado.TabIndex = 6;
            this.label_Resultado.Text = "Resultado:";
            // 
            // textBox_Iteraciones
            // 
            this.textBox_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Iteraciones.Location = new System.Drawing.Point(461, 44);
            this.textBox_Iteraciones.Name = "textBox_Iteraciones";
            this.textBox_Iteraciones.Size = new System.Drawing.Size(117, 34);
            this.textBox_Iteraciones.TabIndex = 7;
            // 
            // textBox_Tolerancia
            // 
            this.textBox_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tolerancia.Location = new System.Drawing.Point(784, 43);
            this.textBox_Tolerancia.Name = "textBox_Tolerancia";
            this.textBox_Tolerancia.Size = new System.Drawing.Size(121, 34);
            this.textBox_Tolerancia.TabIndex = 8;
            // 
            // textBox_InicioIntervalo
            // 
            this.textBox_InicioIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InicioIntervalo.Location = new System.Drawing.Point(359, 142);
            this.textBox_InicioIntervalo.Name = "textBox_InicioIntervalo";
            this.textBox_InicioIntervalo.Size = new System.Drawing.Size(112, 34);
            this.textBox_InicioIntervalo.TabIndex = 9;
            // 
            // textBox_FinIntervalo
            // 
            this.textBox_FinIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FinIntervalo.Location = new System.Drawing.Point(690, 140);
            this.textBox_FinIntervalo.Name = "textBox_FinIntervalo";
            this.textBox_FinIntervalo.Size = new System.Drawing.Size(100, 34);
            this.textBox_FinIntervalo.TabIndex = 10;
            // 
            // label_MostrarResultado
            // 
            this.label_MostrarResultado.BackColor = System.Drawing.SystemColors.Window;
            this.label_MostrarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MostrarResultado.Location = new System.Drawing.Point(509, 277);
            this.label_MostrarResultado.Name = "label_MostrarResultado";
            this.label_MostrarResultado.Size = new System.Drawing.Size(122, 34);
            this.label_MostrarResultado.TabIndex = 11;
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.label_MostrarResultado);
            this.Controls.Add(this.textBox_FinIntervalo);
            this.Controls.Add(this.textBox_InicioIntervalo);
            this.Controls.Add(this.textBox_Tolerancia);
            this.Controls.Add(this.textBox_Iteraciones);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label_FinIntervalo);
            this.Controls.Add(this.label_InicioIntervalo);
            this.Controls.Add(this.label_Tolerancia);
            this.Controls.Add(this.label_iteraciones);
            this.Controls.Add(this.textBox_Funcion);
            this.Controls.Add(this.label_Funcion);
            this.Name = "FormularioInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Funcion;
        private System.Windows.Forms.TextBox textBox_Funcion;
        private System.Windows.Forms.Label label_iteraciones;
        private System.Windows.Forms.Label label_Tolerancia;
        private System.Windows.Forms.Label label_InicioIntervalo;
        private System.Windows.Forms.Label label_FinIntervalo;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.TextBox textBox_Iteraciones;
        private System.Windows.Forms.TextBox textBox_Tolerancia;
        private System.Windows.Forms.TextBox textBox_InicioIntervalo;
        private System.Windows.Forms.TextBox textBox_FinIntervalo;
        private System.Windows.Forms.Label label_MostrarResultado;
    }
}

