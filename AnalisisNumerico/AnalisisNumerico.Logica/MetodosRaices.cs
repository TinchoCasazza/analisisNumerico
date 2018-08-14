using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {
        public ResultadoBiseccion MetodoBiseccion(ParametrosBiseccion parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("a", parametros.ValorInicial);
            var argumento2 = new Argument("b", parametros.ValorFinal);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expresion = new Expression(nombre, funcion, argumento1, argumento2);


            // var resultado = expresion.calculate();

            ResultadoBiseccion resultado = new ResultadoBiseccion();
            resultado = CalcularBiseccion(parametros);
            return resultado;
            //return new ResultadoBiseccion
            //{
            //    Raiz = resultado
            //};
        }

        public ResultadoBiseccion CalcularBiseccion(ParametrosBiseccion parametros)
        {
            double valoresCalculados = (parametros.ValorInicial * parametros.ValorFinal);
            bool termino = false;

            ResultadoBiseccion resultado = new ResultadoBiseccion();
            resultado.Texto = "";

            if (valoresCalculados > 0)
            {
                // perdir de nuevo los valores
                resultado.Texto = "Ingrese otra vez los valores";
                termino = true;
            }
            else if (valoresCalculados == 0)
            {
                if (parametros.ValorInicial == 0)
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

                while (!termino)
                {

                    double Xr = (parametros.ValorFinal + parametros.ValorInicial) / 2;

                    cInteraciones++;

                    Erel = (Xr - antXr) / Xr;

                    if ((Math.Abs(Xr) < parametros.Tolerancia) || (Erel < parametros.Tolerancia) || (cInteraciones > parametros.Iteraciones))
                    {
                        resultado.Raiz = Xr;
                        termino = true;
                    }
                    else
                    {
                        if (valoresCalculados > 0)
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

            return resultado ;
        }
    }

}