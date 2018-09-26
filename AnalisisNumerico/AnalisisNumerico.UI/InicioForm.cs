﻿using AnalisisNumerico.Entidades;
using System;
using System.Windows.Forms;
using AnalisisNumerico.Logica;
using AnalisisNumerico.UI;
using AnalisisNumerico.UI.Form_Sistemas_de_ecuaciones;

namespace AnalisisNumerico.UI
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
        }


        private void bisecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formuBiseccion = Program.container.GetInstance<MetodosCerradosForm>();// (true);
            formuBiseccion.SetPok(true);
            formuBiseccion.Owner = this;
            formuBiseccion.okey = true;
            formuBiseccion.Show();
        }

        private void reglaFalsaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formReglaFalsa = Program.container.GetInstance<MetodosCerradosForm>(); // (false);
            formReglaFalsa.SetPok(false);
            formReglaFalsa.Owner = this;
            formReglaFalsa.okey = false;
            formReglaFalsa.Show();
        }

        private void newtonRaphsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formNewtonRaphson = Program.container.GetInstance<MetodoTangente>();
            formNewtonRaphson.Owner = this;
            formNewtonRaphson.Show();
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSecante = Program.container.GetInstance<MetodoSecante>();
            formSecante.Owner = this;
            formSecante.Show();
        }

        private void gaussJordanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formGaussJordan = Program.container.GetInstance<GaussJordan>();
            formGaussJordan.Owner = this;
            formGaussJordan.Show();           
        }

        private void gaussSeidelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formGaussSeidel = Program.container.GetInstance<GaussSeidel>();
            formGaussSeidel.Owner = this;
            formGaussSeidel.Show();
        }

        private void minimosCuadradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMinimosCuadrados = Program.container.GetInstance<FormRegresion>();
            formMinimosCuadrados.Owner = this;
            formMinimosCuadrados.Show();
        }
    }
}