﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Entidades
{
    public interface ISistemaDeEcuaciones
    {
        ResultadoEcuaciones GaussJordan(ParametrosEcuaciones parametros);
        ResultadoEcuaciones GaussSeidel(ParametrosEcuaciones parametros);
    }
}
