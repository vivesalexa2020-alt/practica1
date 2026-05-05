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

            button1.Click += (sender, e) =>
            {
                CalcularClicked?.Invoke(sender, e);
            };
        }

       

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public event EventHandler CalcularClicked;
    }
}
