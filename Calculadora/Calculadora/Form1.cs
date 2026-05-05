using Calculadora.Vista;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form, ICalculadoraVista
    {
        public Form1()
        {
            InitializeComponent();

            buttonCalcular.Click += (sender, e) =>
            {
                CalcularClicked?.Invoke(sender, e);
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

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

        public event EventHandler CalcularClicked;
    }
}
}