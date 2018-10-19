using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ParametrosRegresion
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }
        public int NumPares { get; set; }
        public int Grado { get; set; }

        public ParametrosRegresion()
        {
            this.X = new List<double>();
            this.Y = new List<double>();
        }
    }
}
