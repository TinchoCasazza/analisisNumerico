namespace AnalisisNumerico.UI
{
    partial class Simpsons
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
            this.button_S13M = new System.Windows.Forms.Button();
            this.textBox_Funcion = new System.Windows.Forms.TextBox();
            this.button_S13S = new System.Windows.Forms.Button();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.label_Funcion = new System.Windows.Forms.Label();
            this.label_ValorFinal = new System.Windows.Forms.Label();
            this.label_ValorInicial = new System.Windows.Forms.Label();
            this.button_S38S = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Resultado.Location = new System.Drawing.Point(241, 278);
            this.textBox_Resultado.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.Size = new System.Drawing.Size(188, 28);
            this.textBox_Resultado.TabIndex = 64;
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_n.Location = new System.Drawing.Point(389, 116);
            this.textBox_n.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(126, 28);
            this.textBox_n.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "n (solo trapecio multiple):";
            // 
            // button_S13M
            // 
            this.button_S13M.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_S13M.Location = new System.Drawing.Point(234, 173);
            this.button_S13M.Margin = new System.Windows.Forms.Padding(2);
            this.button_S13M.Name = "button_S13M";
            this.button_S13M.Size = new System.Drawing.Size(195, 52);
            this.button_S13M.TabIndex = 61;
            this.button_S13M.Text = "Simpson 1/3 Multiple";
            this.button_S13M.UseVisualStyleBackColor = true;
            this.button_S13M.Click += new System.EventHandler(this.button_S13M_Click);
            // 
            // textBox_Funcion
            // 
            this.textBox_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Funcion.Location = new System.Drawing.Point(263, 12);
            this.textBox_Funcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Funcion.Name = "textBox_Funcion";
            this.textBox_Funcion.Size = new System.Drawing.Size(185, 28);
            this.textBox_Funcion.TabIndex = 60;
            // 
            // button_S13S
            // 
            this.button_S13S.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_S13S.Location = new System.Drawing.Point(11, 173);
            this.button_S13S.Margin = new System.Windows.Forms.Padding(2);
            this.button_S13S.Name = "button_S13S";
            this.button_S13S.Size = new System.Drawing.Size(185, 52);
            this.button_S13S.TabIndex = 59;
            this.button_S13S.Text = "Simpson 1/3 Simple";
            this.button_S13S.UseVisualStyleBackColor = true;
            this.button_S13S.Click += new System.EventHandler(this.button_S13S_Click);
            // 
            // textBox_b
            // 
            this.textBox_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_b.Location = new System.Drawing.Point(389, 70);
            this.textBox_b.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(127, 28);
            this.textBox_b.TabIndex = 58;
            // 
            // textBox_a
            // 
            this.textBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_a.Location = new System.Drawing.Point(190, 70);
            this.textBox_a.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(126, 28);
            this.textBox_a.TabIndex = 57;
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(287, 238);
            this.label_Resultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(94, 24);
            this.label_Resultado.TabIndex = 56;
            this.label_Resultado.Text = "Resultado";
            // 
            // label_Funcion
            // 
            this.label_Funcion.AutoSize = true;
            this.label_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Funcion.Location = new System.Drawing.Point(181, 15);
            this.label_Funcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Funcion.Name = "label_Funcion";
            this.label_Funcion.Size = new System.Drawing.Size(85, 24);
            this.label_Funcion.TabIndex = 55;
            this.label_Funcion.Text = "Función:";
            // 
            // label_ValorFinal
            // 
            this.label_ValorFinal.AutoSize = true;
            this.label_ValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorFinal.Location = new System.Drawing.Point(344, 73);
            this.label_ValorFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ValorFinal.Name = "label_ValorFinal";
            this.label_ValorFinal.Size = new System.Drawing.Size(26, 24);
            this.label_ValorFinal.TabIndex = 54;
            this.label_ValorFinal.Text = "b:";
            // 
            // label_ValorInicial
            // 
            this.label_ValorInicial.AutoSize = true;
            this.label_ValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorInicial.Location = new System.Drawing.Point(146, 73);
            this.label_ValorInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ValorInicial.Name = "label_ValorInicial";
            this.label_ValorInicial.Size = new System.Drawing.Size(25, 24);
            this.label_ValorInicial.TabIndex = 53;
            this.label_ValorInicial.Text = "a:";
            // 
            // button_S38S
            // 
            this.button_S38S.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_S38S.Location = new System.Drawing.Point(450, 173);
            this.button_S38S.Margin = new System.Windows.Forms.Padding(2);
            this.button_S38S.Name = "button_S38S";
            this.button_S38S.Size = new System.Drawing.Size(195, 52);
            this.button_S38S.TabIndex = 65;
            this.button_S38S.Text = "Simpson 3/8 Simple";
            this.button_S38S.UseVisualStyleBackColor = true;
            this.button_S38S.Click += new System.EventHandler(this.button_S38S_Click);
            // 
            // Simpsons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(660, 330);
            this.Controls.Add(this.button_S38S);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_S13M);
            this.Controls.Add(this.textBox_Funcion);
            this.Controls.Add(this.button_S13S);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label_Funcion);
            this.Controls.Add(this.label_ValorFinal);
            this.Controls.Add(this.label_ValorInicial);
            this.Name = "Simpsons";
            this.Text = "Simpsons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_S13M;
        private System.Windows.Forms.TextBox textBox_Funcion;
        private System.Windows.Forms.Button button_S13S;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Label label_Funcion;
        private System.Windows.Forms.Label label_ValorFinal;
        private System.Windows.Forms.Label label_ValorInicial;
        private System.Windows.Forms.Button button_S38S;
    }
}