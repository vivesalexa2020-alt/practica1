
/*using Calculadora;
using Calculadora.Modelo;
using Calculadora.Presentacion;

namespace Calculadora
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Crear la View (formulario)
            var vista = new Form1();

            // 2. Crear el Model
            var modelo = new CalculadoraModelo();

            // 3. Crear el Presenter, pasándole la View y el Model
            var presentacion = new CalculadoraPresentacion();

            // 4. Ejecutar la aplicación mostrando el formulario
            Application.Run(vista);
        }
    }
}*/

    using Calculadora.Presentacion;
using Calculadora.Modelo;

namespace Calculadora
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Crear la View (formulario)
            var vista = new Form1();

            // 2. Crear el Model
            var modelo = new CalculadoraModelo();

            // 3. Crear el Presenter, pasándole la View y el Model
            var presenter = new CalculadoraPresentacion(vista,modelo);

            // 4. Ejecutar la aplicación mostrando el formulario
            Application.Run(vista);
        }
    }
}