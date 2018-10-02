using AnalisisNumerico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class GaussSeidel : Form
    {
        private readonly ISistemaDeEcuaciones metodosSistemaEcuaciones;

        public GaussSeidel(ISistemaDeEcuaciones metodosSistema)
        {
            InitializeComponent();
            this.metodosSistemaEcuaciones = metodosSistema;
            this.textBox_Tolerancia.Text = "0,001";
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = int.Parse(textBox_Numincorgnitas.Text);
            dataGridView1.ColumnCount = int.Parse(textBox_Numincorgnitas.Text) + 1;
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            var prueba = new ParametrosEcuaciones { NumIncognitas = int.Parse(textBox_Numincorgnitas.Text), Tolerancia = double.Parse(textBox_Tolerancia.Text) };
            var coef = new List<double>();


            //recorre filas
            var cont = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cont++;
                //recorre las celdas de la columnas
                if (cont <= int.Parse(textBox_Numincorgnitas.Text))
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        coef.Add(Convert.ToDouble(cel.Value));
                    }
                }
            }

            prueba.Coeficientes = coef;
            var resul = metodosSistemaEcuaciones.GaussSeidel(prueba);


            foreach (var item in resul.Resultados)
            {
                dataGridView2.Rows.Add(item).ToString("N6");
            }

        }

        private void button_limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = 1;
            textBox_Numincorgnitas.Text = "";
        }
    }
}
