namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        ResultadoRaices MetodoBiseccionReglaFalsa(ParametrosRaices parametros);

        ResultadoRaices MetodoNewton(ParametrosRaices parametros);
    }
}