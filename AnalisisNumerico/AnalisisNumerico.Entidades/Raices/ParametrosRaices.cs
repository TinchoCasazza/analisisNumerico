namespace AnalisisNumerico.Entidades
{
    public class ParametrosRaices
    {
        public string Funcion { get; set; }

        public double ValorInicial { get; set; }

        public double ValorFinal { get; set; }

        public int Iteraciones { get; set; }

        public double Tolerancia { get; set; }

        public bool Ok { get; set; }
    }
}