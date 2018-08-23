using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;


namespace AnalisisNumerico.Logica.Tests
{
    [TestClass]
    public class TestRaices 
    {
        [TestMethod]
        public void DeberiaCalcularLabiseccion( )
        {
            var parametros = new ParametrosRaices {  Iteraciones=100, Tolerancia= 1 , Ok=true, ValorFinal=-1, ValorInicial =10, Funcion="f(x)=x-7" };
            var resul = new ResultadoRaices();          
        }

       
    }
}
