namespace AnalisisNumerico.UI
{
    partial class MetodoSecante
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ValorInicial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Funcion = new System.Windows.Forms.TextBox();
            this.textBox_Iteraciones = new System.Windows.Forms.TextBox();
            this.textBox_Tolerancia = new System.Windows.Forms.TextBox();
            this.textBox_ValorInicial = new System.Windows.Forms.TextBox();
            this.textBox_Mraiz = new System.Windows.Forms.TextBox();
            this.textBox_ValorFinal = new System.Windows.Forms.TextBox();
            this.textBox_Miteracione = new System.Windows.Forms.TextBox();
            this.textBox_Merror = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iteraciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tolerancia:";
            // 
            // label_ValorInicial
            // 
            this.label_ValorInicial.AutoSize = true;
            this.label_ValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorInicial.Location = new System.Drawing.Point(37, 252);
            this.label_ValorInicial.Name = "label_ValorInicial";
            this.label_ValorInicial.Size = new System.Drawing.Size(143, 29);
            this.label_ValorInicial.TabIndex = 3;
            this.label_ValorInicial.Text = "Valor Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor Final";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Raiz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Iteraciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Error:";
            // 
            // textBox_Funcion
            // 
            this.textBox_Funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Funcion.Location = new System.Drawing.Point(146, 37);
            this.textBox_Funcion.Name = "textBox_Funcion";
            this.textBox_Funcion.Size = new System.Drawing.Size(264, 34);
            this.textBox_Funcion.TabIndex = 9;
            // 
            // textBox_Iteraciones
            // 
            this.textBox_Iteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Iteraciones.Location = new System.Drawing.Point(180, 132);
            this.textBox_Iteraciones.Name = "textBox_Iteraciones";
            this.textBox_Iteraciones.Size = new System.Drawing.Size(162, 34);
            this.textBox_Iteraciones.TabIndex = 10;
            // 
            // textBox_Tolerancia
            // 
            this.textBox_Tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tolerancia.Location = new System.Drawing.Point(586, 139);
            this.textBox_Tolerancia.Name = "textBox_Tolerancia";
            this.textBox_Tolerancia.Size = new System.Drawing.Size(162, 34);
            this.textBox_Tolerancia.TabIndex = 11;
            // 
            // textBox_ValorInicial
            // 
            this.textBox_ValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorInicial.Location = new System.Drawing.Point(186, 252);
            this.textBox_ValorInicial.Name = "textBox_ValorInicial";
            this.textBox_ValorInicial.Size = new System.Drawing.Size(130, 34);
            this.textBox_ValorInicial.TabIndex = 12;
            // 
            // textBox_Mraiz
            // 
            this.textBox_Mraiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mraiz.Location = new System.Drawing.Point(109, 489);
            this.textBox_Mraiz.Name = "textBox_Mraiz";
            this.textBox_Mraiz.Size = new System.Drawing.Size(185, 34);
            this.textBox_Mraiz.TabIndex = 13;
            // 
            // textBox_ValorFinal
            // 
            this.textBox_ValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ValorFinal.Location = new System.Drawing.Point(586, 255);
            this.textBox_ValorFinal.Name = "textBox_ValorFinal";
            this.textBox_ValorFinal.Size = new System.Drawing.Size(162, 34);
            this.textBox_ValorFinal.TabIndex = 14;
            // 
            // textBox_Miteracione
            // 
            this.textBox_Miteracione.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Miteracione.Location = new System.Drawing.Point(539, 489);
            this.textBox_Miteracione.Name = "textBox_Miteracione";
            this.textBox_Miteracione.Size = new System.Drawing.Size(145, 34);
            this.textBox_Miteracione.TabIndex = 15;
            // 
            // textBox_Merror
            // 
            this.textBox_Merror.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Merror.Location = new System.Drawing.Point(846, 488);
            this.textBox_Merror.Name = "textBox_Merror";
            this.textBox_Merror.Size = new System.Drawing.Size(180, 34);
            this.textBox_Merror.TabIndex = 16;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.Location = new System.Drawing.Point(883, 293);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(184, 61);
            this.button_Calcular.TabIndex = 17;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // MetodoSecante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_Merror);
            this.Controls.Add(this.textBox_Miteracione);
            this.Controls.Add(this.textBox_ValorFinal);
            this.Controls.Add(this.textBox_Mraiz);
            this.Controls.Add(this.textBox_ValorInicial);
            this.Controls.Add(this.textBox_Tolerancia);
            this.Controls.Add(this.textBox_Iteraciones);
            this.Controls.Add(this.textBox_Funcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_ValorInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MetodoSecante";
            this.Text = "MetodoSecante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ValorInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Funcion;
        private System.Windows.Forms.TextBox textBox_Iteraciones;
        private System.Windows.Forms.TextBox textBox_Tolerancia;
        private System.Windows.Forms.TextBox textBox_ValorInicial;
        private System.Windows.Forms.TextBox textBox_Mraiz;
        private System.Windows.Forms.TextBox textBox_ValorFinal;
        private System.Windows.Forms.TextBox textBox_Miteracione;
        private System.Windows.Forms.TextBox textBox_Merror;
        private System.Windows.Forms.Button button_Calcular;
    }
}