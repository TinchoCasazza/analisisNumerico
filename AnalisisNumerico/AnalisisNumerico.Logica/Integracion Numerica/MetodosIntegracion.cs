using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosIntegracion : IMetodoIntegracion
    {
        public ResultadoTrapecio MetodoTrapecioSimple(ParametrosTrapecio parametros)
        {
            ResultadoTrapecio resultado = new ResultadoTrapecio();

            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.PrimerValor);
            var argumento2 = new Argument("x", parametros.SegundoValor);

            var f1 = new Expression("f(x)", funcion, argumento1);
            var f2 = new Expression("f(x)", funcion, argumento2);

            resultado.Valor = ((f2.calculate() + f1.calculate()) * (parametros.SegundoValor - parametros.PrimerValor)) / 2;

            return resultado;
        }

        public ResultadoTrapecio MetodoTrapecioMultiple(ParametrosTrapecio parametros)
        {
            double altura = (parametros.SegundoValor - parametros.PrimerValor) / parametros.TercerValor;
            double suma = 0;

            ResultadoTrapecio resultado = new ResultadoTrapecio();

            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.PrimerValor);
            var argumento2 = new Argument("x", parametros.SegundoValor);

            var f1 = new Expression("f(x)", funcion, argumento1);
            var f2 = new Expression("f(x)", funcion, argumento2);

            for (int i = 1; i < parametros.TercerValor; i++)
            {
                var argumento3 = new Argument("x", parametros.PrimerValor + (i * altura));
                var F3 = new Expression("f(x)", funcion, argumento3);
                suma = suma + F3.calculate();
            }

            resultado.Valor = (altura / 2) * (f1.calculate() + 2 * suma + f2.calculate());

            return resultado;
        }
    }
}
