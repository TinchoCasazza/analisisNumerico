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

namespace AnalisisNumerico.UI.Form_Sistemas_de_ecuaciones
{
    public partial class GaussJordan : Form
    {
        private readonly ISistemaDeEcuaciones metodosSistemaEcuaciones;

        public GaussJordan(ISistemaDeEcuaciones sistemaDeEcuaciones)
        {
            InitializeComponent();
            this.metodosSistemaEcuaciones = sistemaDeEcuaciones;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var prueba = new ParametrosEcuaciones { NumIncognitas = int.Parse(textBox_NumIncognitas.Text) };
            var coef = new List<double>();
            //coef.Add(5); coef.Add(2); coef.Add(0); coef.Add(2);
            //coef.Add(2); coef.Add(1); coef.Add(-1); coef.Add(0);
            //coef.Add(2); coef.Add(3); coef.Add(-1); coef.Add(3);

            for (int f = 0; f < int.Parse(textBox_NumIncognitas.Text); f++)
            {
                for (int c = 0; c < int.Parse(textBox_NumIncognitas.Text)+1; c++)
                {
                }
            }

            metodosSistemaEcuaciones.GaussJordan(prueba);

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = int.Parse(textBox_NumIncognitas.Text);
            dataGridView1.ColumnCount = int.Parse(textBox_NumIncognitas.Text) + 1;
        }
    }
}
