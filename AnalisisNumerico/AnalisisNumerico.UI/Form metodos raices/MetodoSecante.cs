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
    public partial class MetodoSecante : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public MetodoSecante(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;
            InitializeComponent();
            textBox_Funcion.Text = "f(x)=";
            textBox_Iteraciones.Text = "100";
            textBox_Tolerancia.Text = "0,0001";
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            var parametros = new ParametrosRaices();
            if (String.IsNullOrWhiteSpace(textBox_Funcion.Text) ||
               String.IsNullOrWhiteSpace(textBox_Tolerancia.Text) ||
              String.IsNullOrWhiteSpace(textBox_Iteraciones.Text) ||
              String.IsNullOrWhiteSpace(textBox_ValorFinal.Text) ||
              String.IsNullOrWhiteSpace(textBox_ValorInicial.Text))
            {
                MessageBox.Show("Faltan ingresar datos", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                parametros.Funcion = textBox_Funcion.Text;
                parametros.Iteraciones = int.Parse(textBox_Iteraciones.Text);
                parametros.Tolerancia = double.Parse(textBox_Tolerancia.Text);
                parametros.ValorInicial = double.Parse(textBox_ValorInicial.Text);
                parametros.ValorFinal = double.Parse(textBox_ValorFinal.Text);

                var resultado = metodosRaices.MetodoSecante(parametros);

                if (resultado.Texto == "")
                {
                    textBox_Merror.Text = resultado.Error.ToString("N8");
                    textBox_Miteracione.Text = resultado.Iteraciones.ToString();
                    textBox_Mraiz.Text = resultado.Raiz.ToString("N8");
                }
                else
                {
                    MessageBox.Show("Error al calcular la raiz", "Notificación", MessageBoxButtons.OK);
                }

            }
        }
    }
}
