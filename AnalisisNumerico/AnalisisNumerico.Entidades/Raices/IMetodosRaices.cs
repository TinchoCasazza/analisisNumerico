namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        ResultadoRaices MetodoBiseccionReglaFalsa(ParametrosRaices parametros);

        ResultadoRaices MetodoTangente(ParametrosRaices parametros);

        ResultadoRaices MetodoSecante(ParametrosRaices parametros);
    }
}