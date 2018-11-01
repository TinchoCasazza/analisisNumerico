using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosIntegracion : IMetodoIntegracion
    {
        public ResultadoIntegracion MetodoTrapecioSimple(ParametrosIntegracion parametros)
        {
            ResultadoIntegracion resultado = new ResultadoIntegracion();

            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.PrimerValor);
            var argumento2 = new Argument("x", parametros.SegundoValor);

            var f1 = new Expression("f(x)", funcion, argumento1);
            var f2 = new Expression("f(x)", funcion, argumento2);

            resultado.Valor = ((f2.calculate() + f1.calculate()) * (parametros.SegundoValor - parametros.PrimerValor)) / 2;

            return resultado;
        }

        public ResultadoIntegracion MetodoTrapecioMultiple(ParametrosIntegracion parametros)
        {
            double altura = (parametros.SegundoValor - parametros.PrimerValor) / parametros.TercerValor;
            double suma = 0;

            ResultadoIntegracion resultado = new ResultadoIntegracion();

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

        public ResultadoIntegracion MetodoSimpson13Simple(ParametrosIntegracion parametros)
        {
            double altura = (parametros.SegundoValor + parametros.PrimerValor) / 2;

            ResultadoIntegracion resultado = new ResultadoIntegracion();

            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.PrimerValor);
            var argumento2 = new Argument("x", parametros.SegundoValor);
            var argumentoaltura = new Argument("x", altura);
            var f1 = new Expression("f(x)", funcion, argumento1);
            var f2 = new Expression("f(x)", funcion, argumento2);
            var faltura = new Expression("f(x)", funcion, argumentoaltura);

            resultado.Valor = ((parametros.SegundoValor - parametros.PrimerValor) / 6) * (f1.calculate() + (4 * faltura.calculate()) + f2.calculate());

            return resultado;
        }

        public ResultadoIntegracion MetodoSimpson13Multiple(ParametrosIntegracion parametros)
        {
            double altura = (parametros.SegundoValor - parametros.PrimerValor) / parametros.TercerValor;

            ResultadoIntegracion resultado = new ResultadoIntegracion();

            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.PrimerValor);
            var argumento2 = new Argument("x", parametros.SegundoValor);
            var f1 = new Expression("f(x)", funcion, argumento1);
            var f2 = new Expression("f(x)", funcion, argumento2);

            double suma1 = 0;
            double suma2 = 0;
            double valor = 0;

            if ((parametros.TercerValor % 2) != 0)
            {
                for (int i = 1; i < parametros.TercerValor - 4; i += 2)
                {
                    var argumento3 = new Argument("x", parametros.PrimerValor + i * altura);
                    var f3 = new Expression("f(x)", funcion, argumento3);
                    suma1 = suma1 + f3.calculate();
                }
                for (int i = 2; i < parametros.TercerValor - 5; i += 2)
                {
                    var argumento3 = new Argument("x", parametros.PrimerValor + i * altura);
                    var f3 = new Expression("f(x)", funcion, argumento3);
                    suma2 = suma2 + f3.calculate();
                }
                ParametrosIntegracion nuevoParametro = new ParametrosIntegracion
                {
                    PrimerValor = parametros.PrimerValor + (parametros.TercerValor - 4) * altura,
                    SegundoValor = parametros.PrimerValor + parametros.TercerValor * altura,
                    Funcion = funcion.ToString()
                };
                valor = MetodoSimpson38(nuevoParametro).Valor;
            }
            else
            {
                for (int i = 1; i < parametros.TercerValor; i += 2)
                {
                    var argumento3 = new Argument("x", parametros.PrimerValor + i * altura);
                    var f3 = new Expression("f(x)", funcion, argumento3);
                    suma1 = suma1 + f3.calculate();
                }
                for (int i = 2; i < parametros.TercerValor - 1; i += 2)
                {
                    var argumento3 = new Argument("x", parametros.PrimerValor + i * altura);
                    var f3 = new Expression("f(x)", funcion, argumento3);
                    suma1 = suma1 + f3.calculate();
                }
            }

            resultado.Valor = ((parametros.SegundoValor - parametros.PrimerValor) / (3 * parametros.TercerValor)) * (f1.calculate() + 4 * suma1 + 2 * suma2 + f2.calculate()) + valor;

            return resultado;

        }

        public ResultadoIntegracion MetodoSimpson38(ParametrosIntegracion parametros)
        {
            double altura = (parametros.SegundoValor - parametros.PrimerValor) / 3;

            ResultadoIntegracion resultado = new ResultadoIntegracion();

            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.PrimerValor);
            var argumento2 = new Argument("x", parametros.SegundoValor);
            var argumento3 = new Argument("x", parametros.PrimerValor + altura);
            var argumento4 = new Argument("x", parametros.PrimerValor + 2 * altura);
            var f1 = new Expression("f(x)", funcion, argumento1);
            var f2 = new Expression("f(x)", funcion, argumento2);
            var f3 = new Expression("f(x)", funcion, argumento3);
            var f4 = new Expression("f(x)", funcion, argumento4);

            resultado.Valor = (0.375 * altura) * (f1.calculate() + 3 * f2.calculate() + 3 * f3.calculate() + f4.calculate());

            return resultado;
        }
    }
}