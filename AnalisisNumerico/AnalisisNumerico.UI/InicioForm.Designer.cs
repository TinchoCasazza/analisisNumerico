﻿namespace AnalisisNumerico.UI
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biseccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaFalsaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reglaFalsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.secanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecuacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussJordanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussSeidelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosCuadradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimosCuadradosPolinomiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lagranjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raicesToolStripMenuItem,
            this.ecuacionesToolStripMenuItem,
            this.regresionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(148, 375);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raicesToolStripMenuItem
            // 
            this.raicesToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.raicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biseccionToolStripMenuItem,
            this.reglaFalsaToolStripMenuItem});
            this.raicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raicesToolStripMenuItem.Name = "raicesToolStripMenuItem";
            this.raicesToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.raicesToolStripMenuItem.Text = "Raices";
            // 
            // biseccionToolStripMenuItem
            // 
            this.biseccionToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.biseccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bisecciónToolStripMenuItem,
            this.reglaFalsaToolStripMenuItem1});
            this.biseccionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biseccionToolStripMenuItem.Name = "biseccionToolStripMenuItem";
            this.biseccionToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.biseccionToolStripMenuItem.Text = "Metodos Cerrados";
            // 
            // bisecciónToolStripMenuItem
            // 
            this.bisecciónToolStripMenuItem.Name = "bisecciónToolStripMenuItem";
            this.bisecciónToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.bisecciónToolStripMenuItem.Text = "Bisección";
            this.bisecciónToolStripMenuItem.Click += new System.EventHandler(this.bisecciónToolStripMenuItem_Click);
            // 
            // reglaFalsaToolStripMenuItem1
            // 
            this.reglaFalsaToolStripMenuItem1.Name = "reglaFalsaToolStripMenuItem1";
            this.reglaFalsaToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.reglaFalsaToolStripMenuItem1.Text = "Regla Falsa";
            this.reglaFalsaToolStripMenuItem1.Click += new System.EventHandler(this.reglaFalsaToolStripMenuItem1_Click);
            // 
            // reglaFalsaToolStripMenuItem
            // 
            this.reglaFalsaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.reglaFalsaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtonRaphsonToolStripMenuItem1,
            this.secanteToolStripMenuItem});
            this.reglaFalsaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reglaFalsaToolStripMenuItem.Name = "reglaFalsaToolStripMenuItem";
            this.reglaFalsaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.reglaFalsaToolStripMenuItem.Text = "Metodos Abiertos";
            // 
            // newtonRaphsonToolStripMenuItem1
            // 
            this.newtonRaphsonToolStripMenuItem1.Name = "newtonRaphsonToolStripMenuItem1";
            this.newtonRaphsonToolStripMenuItem1.Size = new System.Drawing.Size(142, 26);
            this.newtonRaphsonToolStripMenuItem1.Text = "Tangente";
            this.newtonRaphsonToolStripMenuItem1.Click += new System.EventHandler(this.newtonRaphsonToolStripMenuItem1_Click);
            // 
            // secanteToolStripMenuItem
            // 
            this.secanteToolStripMenuItem.Name = "secanteToolStripMenuItem";
            this.secanteToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.secanteToolStripMenuItem.Text = "Secante";
            this.secanteToolStripMenuItem.Click += new System.EventHandler(this.secanteToolStripMenuItem_Click);
            // 
            // ecuacionesToolStripMenuItem
            // 
            this.ecuacionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ecuacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussJordanToolStripMenuItem,
            this.gaussSeidelToolStripMenuItem});
            this.ecuacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecuacionesToolStripMenuItem.Name = "ecuacionesToolStripMenuItem";
            this.ecuacionesToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.ecuacionesToolStripMenuItem.Text = "Ecuaciones";
            // 
            // gaussJordanToolStripMenuItem
            // 
            this.gaussJordanToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.gaussJordanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussJordanToolStripMenuItem.Name = "gaussJordanToolStripMenuItem";
            this.gaussJordanToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.gaussJordanToolStripMenuItem.Text = "Gauss Jordan";
            this.gaussJordanToolStripMenuItem.Click += new System.EventHandler(this.gaussJordanToolStripMenuItem_Click);
            // 
            // gaussSeidelToolStripMenuItem
            // 
            this.gaussSeidelToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.gaussSeidelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussSeidelToolStripMenuItem.Name = "gaussSeidelToolStripMenuItem";
            this.gaussSeidelToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.gaussSeidelToolStripMenuItem.Text = "Gauss Seidel";
            this.gaussSeidelToolStripMenuItem.Click += new System.EventHandler(this.gaussSeidelToolStripMenuItem_Click);
            // 
            // regresionToolStripMenuItem
            // 
            this.regresionToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.regresionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimosCuadradosToolStripMenuItem,
            this.minimosCuadradosPolinomiosToolStripMenuItem,
            this.lagranjeToolStripMenuItem});
            this.regresionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresionToolStripMenuItem.Name = "regresionToolStripMenuItem";
            this.regresionToolStripMenuItem.Size = new System.Drawing.Size(139, 36);
            this.regresionToolStripMenuItem.Text = "Regresion";
            // 
            // minimosCuadradosToolStripMenuItem
            // 
            this.minimosCuadradosToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.minimosCuadradosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimosCuadradosToolStripMenuItem.Name = "minimosCuadradosToolStripMenuItem";
            this.minimosCuadradosToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.minimosCuadradosToolStripMenuItem.Text = "Minimos cuadrados";
            this.minimosCuadradosToolStripMenuItem.Click += new System.EventHandler(this.minimosCuadradosToolStripMenuItem_Click);
            // 
            // minimosCuadradosPolinomiosToolStripMenuItem
            // 
            this.minimosCuadradosPolinomiosToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.minimosCuadradosPolinomiosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimosCuadradosPolinomiosToolStripMenuItem.Name = "minimosCuadradosPolinomiosToolStripMenuItem";
            this.minimosCuadradosPolinomiosToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.minimosCuadradosPolinomiosToolStripMenuItem.Text = "Minimos cuadrados polinomios";
            this.minimosCuadradosPolinomiosToolStripMenuItem.Click += new System.EventHandler(this.minimosCuadradosPolinomiosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lagranjeToolStripMenuItem
            // 
            this.lagranjeToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.lagranjeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagranjeToolStripMenuItem.Name = "lagranjeToolStripMenuItem";
            this.lagranjeToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.lagranjeToolStripMenuItem.Text = "Lagranje";
            this.lagranjeToolStripMenuItem.Click += new System.EventHandler(this.lagranjeToolStripMenuItem_Click);
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioForm";
            this.Text = "Métodos Raíces";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biseccionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem bisecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reglaFalsaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reglaFalsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem secanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecuacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussJordanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussSeidelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosCuadradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimosCuadradosPolinomiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagranjeToolStripMenuItem;
    }
}

