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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InicioForm_Load(object sender, EventArgs e)
        {
          
        }

        private void biseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formuBiseccion = new RaicesForm(metodosRaices);
            formuBiseccion.Owner = this;
            formuBiseccion.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}