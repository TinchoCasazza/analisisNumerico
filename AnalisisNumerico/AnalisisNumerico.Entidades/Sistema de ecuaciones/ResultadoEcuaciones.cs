﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public class ResultadoEcuaciones
    {
        public List<double> Resultados { get; set; }
        public ResultadoEcuaciones()
        {
            this.Resultados = new List<double>();
        }
    }
}
