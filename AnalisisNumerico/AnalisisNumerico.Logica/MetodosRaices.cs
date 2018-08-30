using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {
        public ResultadoRaices MetodoBiseccionReglaFalsa(ParametrosRaices parametros)
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
                        Xr = CalcularXrBiseccion(parametros.ValorInicial, parametros.ValorFinal);
                    }
                    else
                    {
                        Xr = CalcularXrReglaFalsa(parametros.ValorInicial, parametros.ValorFinal, parametros.Funcion);
                    }
                    cInteraciones++;

                    Erel = (Xr - antXr) / Xr; //Ver el caso que divide por 0

                    //var argumentoXr = new Argument("x", Xr);
                    //var expresionXr = new Expression(nombre, funcion, argumentoXr);
              
                    if ((Math.Abs(RetornarImagen(parametros.Funcion, Xr)) < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones) || (Math.Abs(Erel) < parametros.Tolerancia))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                    }
                    else
                    {
                        //var imagenvalorinicial = expresion1.calculate();
                        //var imagenvalorxr = RetornarImagen(parametros.Funcion, Xr);
                        if ((expresion1.calculate()) * RetornarImagen(parametros.Funcion, Xr) > 0)
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
                resultado.Error = Math.Abs(Erel);
            }
            return resultado;
        }

        private double RetornarImagen(string funcion, double xr)
        {
            //var imagen = new Function(funcion).calculate(xr);
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

        public ResultadoRaices MetodoTangente(ParametrosRaices parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.ValorInicial);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expresion1 = new Expression(nombre, funcion, argumento1);

            bool termino = false;

            ResultadoRaices resultado = new ResultadoRaices();
            resultado.Texto = "";

            double Xini = parametros.ValorInicial;

            if (RetornarImagen(parametros.Funcion, Xini) == 0) // si el F(x1) es 0
            {
                // x1 es raiz
                resultado.Raiz = Xini;
            }
            else
            {
                int cInteraciones = 0;
                double antXr = 0;
                double Erel = 0;
                double Xr = 0;
                double dFx = 0;

                while (!termino)
                {
                    double aproximacion = Xini + parametros.Tolerancia;

                    var imagenaproximaxion = RetornarImagen(parametros.Funcion, aproximacion);
                    var imagenxini = RetornarImagen(parametros.Funcion, Xini);

                    dFx = (RetornarImagen(parametros.Funcion, aproximacion) - RetornarImagen(parametros.Funcion, Xini)) / parametros.Tolerancia;

                    Xr = parametros.ValorInicial - (RetornarImagen(parametros.Funcion, parametros.ValorInicial) / dFx);

                    cInteraciones++;

                    Erel = Math.Abs(Xr - antXr) / Xr;

                    if ((Math.Abs(RetornarImagen(parametros.Funcion, Xr)) < parametros.Tolerancia) || (Math.Abs(Erel) < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                        break;
                    }
                    else
                    {
                        antXr = Xini;

                        Xini = Xr;
                    }
                }
                resultado.Iteraciones = cInteraciones;
                resultado.Error = Math.Abs(Erel);
            }
            return resultado;
        }

        public ResultadoRaices MetodoSecante(ParametrosRaices parametros)
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

            double Xini0 = parametros.ValorInicial;
            double Xini1 = parametros.ValorFinal;
            double Xini2 = 0;

            double Xant = 0;

            var imagen1 = RetornarImagen(parametros.Funcion, Xini1);
            var imagen11 = RetornarImagen(parametros.Funcion, Xini0);

            Xini2 = ((RetornarImagen(parametros.Funcion, Xini1) * Xini0) - (RetornarImagen(parametros.Funcion, Xini0) * Xini1) / (RetornarImagen(parametros.Funcion, Xini1) - RetornarImagen(parametros.Funcion, Xini0)));

            if ((RetornarImagen(parametros.Funcion, Xini0) * RetornarImagen(parametros.Funcion, Xini1)) == 0)
            {
                // x1 es raiz
                resultado.Raiz = Xini0;
            }
            else
            {
                int cInteraciones = 0;
                double Erel = 0;

                while (!termino)
                {

                    cInteraciones++;
                    Xant = Xini2;

                    Xini0 = Xini1;
                    Xini1 = Xini2;

                    Xini2 = ((RetornarImagen(parametros.Funcion, Xini1) * Xini0) - RetornarImagen(parametros.Funcion, Xini0) * Xini1) / (RetornarImagen(parametros.Funcion, Xini1) - RetornarImagen(parametros.Funcion, Xini0));

                    Erel = (Xini2 - Xant) / Xini2;

                    if ((Math.Abs(RetornarImagen(parametros.Funcion, Xini2)) < parametros.Tolerancia) || (Math.Abs(Erel) < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones))
                    {
                        resultado.Raiz = Xini2;
                        resultado.Error = Erel;
                        termino = true;
                        break;
                    }
                }
                resultado.Iteraciones = cInteraciones;
                resultado.Error = Erel;
            }
            return resultado;
        }
    }
}