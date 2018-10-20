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
    public partial class MinimosCuadradosPolinomio : Form
    {
        private readonly IRegresion metodosRegresion;

        public MinimosCuadradosPolinomio(   IRegresion metodosRegresion)
        {
            InitializeComponent();
            this.metodosRegresion = metodosRegresion;
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView2.RowCount = 1;
            textBox_CantidadPares.Text = "";
            textBox_Grado.Text = "";
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            var paramtros = new ParametrosRegresion();

            paramtros.Error = int.Parse(textBox_Error.Text);

            //recorre filas
            var cont = 0;
            bool uno = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cont++;
                if (cont <= int.Parse(textBox_CantidadPares.Text))
                {//recorre las celdas de la columnas
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        if (uno == true)
                        {
                            paramtros.X.Add(Convert.ToDouble(cel.Value));
                            uno = false;
                        }
                        else
                        {
                            paramtros.Y.Add(Convert.ToDouble(cel.Value));
                            uno = true;
                        }
                    }
                }
            }
            paramtros.NumPares = int.Parse(textBox_CantidadPares.Text);
            paramtros.Grado = int.Parse(textBox_Grado.Text);

            var m = metodosRegresion.MinimosCuadradosPolinomioGradoN(paramtros);


            foreach (var item in m.Resul)
            {
                dataGridView2.Rows.Add(item);
            }

            textBoxEfectividad.Text = m.Efectividad.ToString("N2");

            textBox_Gradfinal.Text = m.GradoFinal.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = int.Parse(textBox_CantidadPares.Text);
            dataGridView1.ColumnCount = 2;
        }
    }
}
