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

namespace AnalisisNumerico.UI.Regresion
{
    public partial class FormLagranje : Form
    {
        private readonly IRegresion metodoLagranje;

        public FormLagranje(IRegresion metodoLagranje)
        {
            InitializeComponent();
            this.metodoLagranje = metodoLagranje;
        }

        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = int.Parse(textBox_cantPares.Text);
            dataGridView1.ColumnCount = 2;
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            var paramtros = new ParametrosRegresion();
            double valorX = Convert.ToDouble(textBox_valX.Text);

            //recorre filas
            var cont = 0;
            bool uno = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cont++;
                if (cont <= int.Parse(textBox_cantPares.Text))
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
            paramtros.NumPares = int.Parse(textBox_cantPares.Text);

            var resul = metodoLagranje.PolinomioLagranje(paramtros, valorX);

            textBox_Interpolacion.Text = resul.Interpolacion.ToString();

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            textBox_Interpolacion.Text = "";
            textBox_cantPares.Text = "";
        }
    }
    
}
