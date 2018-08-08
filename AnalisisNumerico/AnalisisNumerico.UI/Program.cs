using System;
using SimpleInjector;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;


namespace AnalisisNumerico.UI
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<FormularioInicio>());
        }

        private static void Bootstrap()
        {
            //Create the container as usual
            container = new Container();

            container.Register<IMetodosRaices, MetodosRaices>(); 
            container.Register<FormularioInicio>();
        }
    }
}
