using Calculadora.Vista;
namespace Calculadora
{
    public partial class Form1 : Form, ICalculadoraVista
    {
        public Form1()
        {
            InitializeComponent();

            // Cuando se haga clic en el botón, se dispara el evento
            buttonCalcular.Click += (sender, e) =>


            {
                CalcularClicked?.Invoke(sender, e);
            };
        }

        // Propiedades
        public string Numero1
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public string Numero2
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }

        public string Resultado
        {
            get => labelResultado.Text;
            set => labelResultado.Text = value;
        }

        // Evento
        public event EventHandler CalcularClicked;
    }
}






   
    
       
        
           

           
         
      