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


        public ResultadoRegresion MinimosCuadradosPolinomioGradoN(ParametrosRegresion parametros)
        {
            var resul = new ResultadoRegresion();

            double sumatoriaX = parametros.X.Sum();
            double sumatoriaY = parametros.Y.Sum();
            double r = 0;

            while (parametros.Grado <= 10 && r <= parametros.Error)
            {
                double[,] matriz = new double[parametros.Grado + 1, parametros.Grado + 2];

                resul = null;
                resul = new ResultadoRegresion();

                var pot = 0;
                for (int columna = 0; columna < parametros.Grado + 1; columna++)
                {
                    if (columna > 0)
                    {
                        pot = columna;
                        for (int i = 0; i < parametros.Grado + 1; i++)
                        {
                            matriz[i, columna] = RetornarSumXpotencia(parametros.X, pot);
                            pot++;
                        }
                    }
                    else if (columna == 0)
                    {
                        pot = 1;
                        matriz[0, 0] = parametros.NumPares;
                        for (int i = 1; i < parametros.Grado + 1; i++)
                        {
                            matriz[i, columna] = RetornarSumXpotencia(parametros.X, pot);
                            pot++;
                        }
                    }
                }

                for (int i = 0; i < parametros.Grado + 1; i++)
                {
                    if (i != 0)
                    {
                        pot = 1;
                        matriz[i, parametros.Grado + 1] = RetornarXPorY(i, parametros.X, parametros.Y);
                        pot++;
                    }
                    else
                    {
                        matriz[i, parametros.Grado + 1] = parametros.Y.Sum();
                    }

                }

                var SistemaDeEcucuaciones = new SistemaDeEcuaciones();
                var param = new ParametrosEcuaciones();
                param.NumIncognitas = parametros.Grado + 1;

                for (int i = 0; i < parametros.Grado + 1; i++)
                {
                    for (int c = 0; c < parametros.Grado + 2; c++)
                    {
                        param.Coeficientes.Add(matriz[i, c]);
                    }
                }

                var resultadoGauss = SistemaDeEcucuaciones.GaussJordan(param);

                r = CalcularR(parametros.X, parametros.Y, resultadoGauss.Resultados);

                parametros.Grado++;

                resul.Efectividad = r;
                resul.Resul = resultadoGauss.Resultados;
                resul.GradoFinal = parametros.Grado -1;
            }

            return resul;
        }

        private double RetornarSumXpotencia(List<double> lista, int potencia)
        {
            double suma = 0;
            foreach (var item in lista)
            {
                suma = suma + Math.Pow(item, potencia);
            }
            return suma;
        }

        private double RetornarXPorY(int potencia, List<double> x, List<double> y)
        {
            double xpory = 0;

            for (int i = 0; i < x.Count; i++)
            {
                xpory = xpory + Math.Pow(x[i], potencia) * y[i];
            }
            return xpory;

        }

        private double CalcularR(List<double> ListaX, List<double> ListaY, List<double> lista)
        {
            double Yprom = ListaY.Sum() / ListaY.Count();
            double st = 0;

            double sr = 0;
            double r = 0;

            foreach (var item in ListaY)
            {
                st = st + Math.Pow((item - Yprom), 2);
            }

            double acu = 0;

            for (int i = 0; i < ListaX.Count; i++)
            {
                int potencia = 0;
                foreach (var item in lista)
                {
                    acu = acu - item * Math.Pow(ListaX[i], potencia);
                    potencia++;
                }
                sr = sr + Math.Pow((ListaY[i] + acu), 2);
                acu = 0;
            }
            r = Math.Sqrt((st - sr) / st) * 100;


            return r;
        }

        public ResultadoLagranje PolinomioLagranje(ParametrosRegresion parametros, double valorX)
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
                        numerador = (x - parametros.X[j]) * numerador;
                        denominador = (parametros.X[i] - parametros.X[j]) * denominador;
                    }
                }

                sumaY = (numerador / denominador) * parametros.X[i] + sumaY;

            }

            resultado.Interpolacion = sumaY;

            return resultado;
        }


    }
}
