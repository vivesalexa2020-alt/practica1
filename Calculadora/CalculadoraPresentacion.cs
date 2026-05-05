using System;
using Calculadora.Vista;
namespace Calculadora.Presentacion
{
    public class CalculadoraPresentacion
    {
        private ICalculadoraVista vista;
        private CalculadoraModelo modelo;

        // El constructor recibe la View y el Model
        public CalculadoraPresentacion(ICalculadoraVista vista, CalculadoraModelo modelo)
        {
            vista = vista;
            modelo = modelo;

            // Suscribirse al evento de la View
            vista.CalcularClicked += OnCalcularClick;
        }

        // Este método se ejecuta cuando el usuario hace clic
        private void OnCalcularClick(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(vista.Numero1) || string.IsNullOrWhiteSpace(vista.Numero2))
            {
                vista.Resultado = "Error: Ingresa ambos números";
                return;
            }

            // 2. Intentar convertir los textos a números
            if (int.TryParse(vista.Numero1, out int num1) && int.TryParse(_vista.Numero2, out int num2))
            {
                // 3. Usar el Model para hacer el cálculo
                int suma = modelo.Sumar(num1, num2);

                // 4. Actualizar la View con el resultado
                vista.Resultado = suma.ToString();
            }
            else
            {
                vista.Resultado = "Error: Debes ingresar números válidos";
            }
        }
    }
}
