using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {
        public ResultadoRaices MetodoBiseccion(ParametrosRaices parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.ValorInicial);
            var argumento2 = new Argument("x", parametros.ValorFinal);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expresion1 = new Expression(nombre, funcion, argumento1);
            var expresion2 = new Expression(nombre, funcion, argumento2);

            bool termino = false;

            ResultadoRaices resultado = new ResultadoRaices();
            resultado.Texto = "";

            if (expresion1.calculate() * expresion2.calculate() > 0)
            {
                resultado.Texto = "Ingrese otra vez los valores";
                termino = true;
            }
            else if (expresion1.calculate() * expresion2.calculate() == 0)
            {
                if (expresion1.calculate() == 0)
                {
                    resultado.Raiz = parametros.ValorInicial;
                }
                else
                {
                    resultado.Raiz = parametros.ValorFinal;
                }
            }
            else
            {
                int cInteraciones = 0;
                double antXr = 0;
                double Erel = 0;
                double Xr = 0;

                while (!termino)
                {                    
                    if (parametros.Ok)
                    {
                        Xr = CalcularXrBiseccion(parametros.ValorInicial , parametros.ValorFinal);
                    }
                    else
                    {
                        Xr = CalcularXrReglaFalsa(parametros.ValorInicial, parametros.ValorFinal,parametros.Funcion);
                    }
                    cInteraciones++;

                    Erel = (Xr - antXr) / Xr;

                    if ((Math.Abs(RetornarImagen(parametros.Funcion, Xr)) < parametros.Tolerancia) || (Math.Abs(Erel) < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                    }
                    else
                    {
                        if ((RetornarImagen(parametros.Funcion, parametros.ValorInicial) * RetornarImagen(parametros.Funcion, Xr)) > 0)
                        {
                            parametros.ValorInicial = Xr;
                        }
                        else
                        {
                            parametros.ValorFinal = Xr;
                        }
                        antXr = Xr;
                    }
                }
                resultado.Iteraciones = cInteraciones;
                resultado.Error = Erel;
            }
            return resultado;
        }

        private double RetornarImagen(string funcion, double xr)
        {
            return new Function(funcion).calculate(xr);
        }

        private double CalcularXrBiseccion(double xi, double xd)
        {
            return (xi + xd) / 2;
        }

        private double CalcularXrReglaFalsa(double xi, double xd, string pfuncion)
        {
            return ((RetornarImagen(pfuncion, xd) * xi) - (RetornarImagen(pfuncion, xi) * xd)) / (RetornarImagen(pfuncion, xd) - RetornarImagen(pfuncion, xi));
        }

        public ResultadoRaices MetodoNewton(ParametrosRaices parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.ValorInicial);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expresion1 = new Expression(nombre, funcion, argumento1);
            var expresion2 = new Expression(nombre, funcion, argumento2);

            bool termino = false;

            ResultadoRaices resultado = new ResultadoRaices();
            resultado.Texto = "";

            if ( RetornarImagen(parametros.funcion , parametros.ValorInicial) == 0) // si el F(x1) es 0
            {
                // x1 es raiz
                resultado.raiz = parametros.ValorInicial;
            }
            else
            {
                int cInteraciones = 0;
                double antXr = 0;
                double Erel = 0;
                double Xr = 0;

                while (!termino)
                {                    
                    Xr = parametros.ValorInicial - ( RetornarImagen(parametros.funcion , parametros.ValorInicial) / )

                    cInteraciones++;

                    Erel = (Xr - antXr) / Xr;

                    if ((Math.Abs(RetornarImagen(parametros.Funcion, Xr)) < parametros.Tolerancia) || (Math.Abs(Erel) < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                    }
                    else
                    {
                        antXr = parametros.ValorInicial;

                        parametros.ValorInicial = Xr;
                    }
                }
                resultado.Iteraciones = cInteraciones;
                resultado.Error = Erel;
            }
            return resultado;
        }

    }
}