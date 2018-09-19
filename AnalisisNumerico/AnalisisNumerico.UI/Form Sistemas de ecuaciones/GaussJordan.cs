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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            var prueba = new ParametrosEcuaciones { NumIncognitas = 3 };
            var coef = new List<double>();
            coef.Add(5); coef.Add(2); coef.Add(0); coef.Add(2);
            coef.Add(2); coef.Add(1); coef.Add(-1); coef.Add(0);
            coef.Add(2); coef.Add(3); coef.Add(-1); coef.Add(3);

            metodosSistemaEcuaciones.GaussJordan(prueba);
        }
    }
}
