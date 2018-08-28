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
    public partial class MetodosCerradosForm : Form
    {
        private readonly IMetodosRaices metodosRaices;
        private bool okey;

        public MetodosCerradosForm(IMetodosRaices metodosRaices, bool pok)
        {
            this.metodosRaices = metodosRaices;
            InitializeComponent();
            textBox_Funcion.Text = "f(x)=";
            textBox_Iteraciones.Text = "100";
            textBox_Tolerancia.Text = "0,0001";
            okey = pok;
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            var parametros = new ParametrosRaices();
            // Se comprueba que no exista texbox sin datos
            if (String.IsNullOrWhiteSpace(textBox_Funcion.Text) ||
                String.IsNullOrWhiteSpace(textBox_Tolerancia.Text) ||
               String.IsNullOrWhiteSpace(textBox_Iteraciones.Text) ||
               String.IsNullOrWhiteSpace(textBox_ValorFinal.Text) ||
               String.IsNullOrWhiteSpace(textBox_ValorInical.Text))
            {
                MessageBox.Show("Faltan ingresar datos", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                parametros.Funcion = textBox_Funcion.Text;
                parametros.Iteraciones = int.Parse(textBox_Iteraciones.Text);
                parametros.Tolerancia = double.Parse(textBox_Tolerancia.Text);
                parametros.ValorFinal = double.Parse(textBox_ValorFinal.Text);
                parametros.ValorInicial = double.Parse(textBox_ValorInical.Text);
                parametros.Ok = okey;

                var resultado = metodosRaices.MetodoBiseccionReglaFalsa(parametros);

                if (resultado.Texto == "")
                {
                    textBox_MostrarError.Text = resultado.Error.ToString("N8");
                    textBox_MostrarIteraciones.Text = resultado.Iteraciones.ToString();
                    textBox_MostrarRaiz.Text = resultado.Raiz.ToString("N8");
                }
                else
                {
                    MessageBox.Show("Los extremos ingresados no son válidos", "Notificación", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox_Iteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void textBox_Tolerancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //        ControlTeclas(sender, e , textBox_Tolerancia);
        }

        private void textBox_ValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //          ControlTeclas(sender, e, textBox_ValorFinal);
        }

        private void textBox_ValorInical_KeyPress(object sender, KeyPressEventArgs e)
        {
            //            ControlTeclas(sender, e, textBox_ValorInical);
        }

        //private void ControlTeclas(object sender, KeyPressEventArgs e, TextBox textBox)
        //{
        //    if (textBox.Text.Contains(","))
        //    {
        //        if (!char.IsDigit(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //        if (e.KeyChar == '\b')
        //        {
        //            e.Handled = false;
        //        }
        //    }
        //    else
        //    {
        //        if (!char.IsDigit(e.KeyChar))
        //        {
        //            e.Handled = true;
        //        }
        //        if (e.KeyChar == ',' || e.KeyChar == '\b')
        //        {
        //            e.Handled = false;
        //        }
        //    }
        //} // Solo numeros y la coma
    }
}
