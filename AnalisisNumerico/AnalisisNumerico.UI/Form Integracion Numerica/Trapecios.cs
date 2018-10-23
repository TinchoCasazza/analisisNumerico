using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.UI
{
    public partial class Trapecios : Form
    {
        private readonly IMetodoIntegracion metodoIntegracion;

        public Trapecios(IMetodoIntegracion metodoIntegracion)
        {
            this.metodoIntegracion = metodoIntegracion;
            InitializeComponent();
            textBox_Funcion.Text = "f(x)=";
        }

        private void Button_Trapecio_Click_1(object sender, EventArgs e)
        {
            var parametros = new ParametrosTrapecio();
            // Se comprueba que no exista texbox sin datos
            if (String.IsNullOrWhiteSpace(textBox_Funcion.Text) ||
                String.IsNullOrWhiteSpace(textBox_a.Text) ||
               String.IsNullOrWhiteSpace(textBox_b.Text))
            {
                MessageBox.Show("Faltan ingresar datos", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                parametros.Funcion = textBox_Funcion.Text;
                parametros.PrimerValor = double.Parse(textBox_a.Text);
                parametros.SegundoValor = double.Parse(textBox_b.Text);

                var resultado = metodoIntegracion.MetodoTrapecioSimple(parametros);

                textBox_Resultado.Text = resultado.Valor.ToString("N8");
            }
        }

        private void Button_TMultiple_Click_1(object sender, EventArgs e)
        {
            var parametros = new ParametrosTrapecio();
            // Se comprueba que no exista texbox sin datos
            if (String.IsNullOrWhiteSpace(textBox_Funcion.Text) ||
                String.IsNullOrWhiteSpace(textBox_a.Text) ||
               String.IsNullOrWhiteSpace(textBox_b.Text) ||
               String.IsNullOrWhiteSpace(textBox_n.Text))
            {
                MessageBox.Show("Faltan ingresar datos", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                parametros.Funcion = textBox_Funcion.Text;
                parametros.PrimerValor = double.Parse(textBox_a.Text);
                parametros.SegundoValor = double.Parse(textBox_b.Text);
                parametros.TercerValor = int.Parse(textBox_n.Text);

                var resultado = metodoIntegracion.MetodoTrapecioMultiple(parametros);

                textBox_Resultado.Text = resultado.Valor.ToString("N8");
            }
        }
    }
}
