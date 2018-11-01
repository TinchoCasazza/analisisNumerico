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
    public partial class Simpsons : Form
    {
        private readonly IMetodoIntegracion metodoIntegracion;

        public Simpsons(IMetodoIntegracion metodoIntegracion)
        {
            this.metodoIntegracion = metodoIntegracion;
            InitializeComponent();
            textBox_Funcion.Text = "f(x)=";
        }

        private void button_S13S_Click(object sender, EventArgs e)
        {
            var parametros = new ParametrosIntegracion();
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

                var resultado = metodoIntegracion.MetodoSimpson13Simple(parametros);

                textBox_Resultado.Text = resultado.Valor.ToString("N8");
            }
        }

        private void button_S13M_Click(object sender, EventArgs e)
        {
            var parametros = new ParametrosIntegracion();
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

                var resultado = metodoIntegracion.MetodoSimpson13Multiple(parametros);

                textBox_Resultado.Text = resultado.Valor.ToString("N8");
            }
        }

        private void button_S38S_Click(object sender, EventArgs e)
        {
            var parametros = new ParametrosIntegracion();
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

                var resultado = metodoIntegracion.MetodoSimpson38(parametros);

                textBox_Resultado.Text = resultado.Valor.ToString("N8");
            }
        }
    }
}
