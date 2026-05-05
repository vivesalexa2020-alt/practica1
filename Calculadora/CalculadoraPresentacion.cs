using System;

namespace Calculadora.Presentacion
{
    public class CalculadoraPresentacion
    {
        private ICalculadoraVista _vista;
        private CalculadoraModelo _modelo;

        // El constructor recibe la View y el Model
        public CalculadoraPresentacion(ICalculadoraVista vista, CalculadoraModelo modelo)
        {
            _vista = vista;
            _modelo = modelo;

            // Suscribirse al evento de la View
            _vista.CalcularClicked += OnCalcularClick;
        }

        // Este método se ejecuta cuando el usuario hace clic
        private void OnCalcularClick(object sender, EventArgs e)
        {
            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(_vista.Numero1) || string.IsNullOrWhiteSpace(_vista.Numero2))
            {
                _vista.Resultado = "Error: Ingresa ambos números";
                return;
            }

            // 2. Intentar convertir los textos a números
            if (int.TryParse(_view.Numero1, out int num1) && int.TryParse(_vista.Numero2, out int num2))
            {
                // 3. Usar el Model para hacer el cálculo
                int suma = _modelo.Sumar(num1, num2);

                // 4. Actualizar la View con el resultado
                _vista.Resultado = suma.ToString();
            }
            else
            {
                _vista.Resultado = "Error: Debes ingresar números válidos";
            }
        }
    }
}
