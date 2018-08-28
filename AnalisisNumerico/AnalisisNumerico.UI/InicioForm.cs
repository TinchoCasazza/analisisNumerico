using AnalisisNumerico.Entidades;
using System;
using System.Windows.Forms;
using AnalisisNumerico.Logica;
using AnalisisNumerico.UI;

namespace AnalisisNumerico.UI
{
    public partial class InicioForm : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public InicioForm(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;   
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            //var funcion = FuncionTextBox.Text;
            //var valorInicial = Convert.ToInt32(ValorInicialTextBox.Text);
            //var valorFinal = Convert.ToInt32(ValorFinalTextBox.Text);

            //var resultado = metodosRaices.MetodoBiseccion(new ParametrosBiseccion
            //{
            //    Funcion = funcion,
            //    ValorInicial = valorInicial,
            //    ValorFinal = valorFinal
            //});

            //MessageBox.Show(resultado.Raiz.ToString());
        }


        private void bisecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            var formuBiseccion = new MetodosCerradosForm(metodosRaices, true);
            formuBiseccion.Owner = this;
            formuBiseccion.Show();
        }

        private void reglaFalsaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //
            var formReglaFalsa = new MetodosCerradosForm(metodosRaices, false);
            formReglaFalsa.Owner = this;
            formReglaFalsa.Show();
        }

        private void newtonRaphsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formNewtonRaphson = new MetodoTangente(metodosRaices);
            formNewtonRaphson.Owner = this;
            formNewtonRaphson.Show();
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSecante = new MetodoSecante(metodosRaices);
            formSecante.Owner = this;
            formSecante.Show();
        }


    }
}