using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalisisNumerico.Entidades;

namespace AnalisisNumerico.Logica
{
    public class MetodosRegresion : IRegresion
    {
        public ResultadoRegresion MinimosCuadrados(ParametrosRegresion parametros)
        {
            var resultado = new ResultadoRegresion();

            var numeroDePares = parametros.NumPares;

            double sumatoriaX = parametros.X.Sum();
            double sumatoriaY = parametros.Y.Sum();

            double sumatoriaXCuadrado = 0;

            double promedioX = parametros.X.Sum() / parametros.NumPares;
            double promedioY = parametros.Y.Sum() / parametros.NumPares;

            foreach (var item in parametros.X)
            {
                sumatoriaXCuadrado = (sumatoriaXCuadrado + (item * item));
            }

            double sumatoriaXporY = 0;

            for (int i = 0; i < numeroDePares; i++)
            {
                sumatoriaXporY = sumatoriaXporY + (parametros.X[i] * parametros.Y[i]);
            }

            double deltaA1 = (numeroDePares * sumatoriaXporY) - (sumatoriaX * sumatoriaY);

            double delta = (numeroDePares * sumatoriaXCuadrado) - (sumatoriaX * sumatoriaX);

            resultado.Pendiente = deltaA1 / delta;
            resultado.OrdenadaOrigen = promedioY - (resultado.Pendiente * promedioX);

            return resultado;
        }

        public ResultadoLagranje PolinomioLagranje(ParametrosRegresion parametros , double valorX)
        {
            var resultado = new ResultadoLagranje();

            double x = valorX;
            double sumaY = 0; 

            for (int i = 0; i < parametros.X.Count; i++)
            {
                double numerador = 1;
                double denominador = 1;

                for (int j = 0; j < parametros.X.Count; j++)
                {
                   
                    if (i != j)
                    {
                        numerador = (x - parametros.X[j]) * numerador ;
                        denominador = (parametros.X[i] - parametros.X[j]) * denominador;
                    }
                }

                sumaY = (numerador / denominador) * parametros.X[i] + sumaY;
            
            }
            
            resultado.

            return resultado;
        }

   
    }
}
