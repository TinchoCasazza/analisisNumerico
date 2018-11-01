namespace AnalisisNumerico.Entidades
{
    public interface IMetodoIntegracion
    {
        ResultadoIntegracion MetodoTrapecioSimple(ParametrosIntegracion parametros);

        ResultadoIntegracion MetodoTrapecioMultiple(ParametrosIntegracion parametros);

        ResultadoIntegracion MetodoSimpson13Simple(ParametrosIntegracion parametros);

        ResultadoIntegracion MetodoSimpson13Multiple(ParametrosIntegracion parametros);

        ResultadoIntegracion MetodoSimpson38(ParametrosIntegracion parametros);
    }
}
