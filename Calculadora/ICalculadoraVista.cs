using System;

namespace Calculadora.Vista
{
    public interface ICalculadoraVista
    {
        // Propiedades que el Presenter leerá o escribirá
        string Numero1 { get; set; }
        string Numero2 { get; set; }
        string Resultado { get; set; }

        // Evento que el Presenter "escuchará" para actuar
        event EventHandler CalcularClicked;
    }
}
