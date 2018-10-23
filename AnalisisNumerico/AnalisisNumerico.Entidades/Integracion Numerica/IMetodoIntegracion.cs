namespace AnalisisNumerico.Entidades
{
    public interface IMetodoIntegracion
    {
        ResultadoTrapecio MetodoTrapecioSimple(ParametrosTrapecio parametros);

        ResultadoTrapecio MetodoTrapecioMultiple(ParametrosTrapecio parametros);
    }
}
