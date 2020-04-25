using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._8
{
    public partial class Form1: Form
    {
        Calculadora calc = new Calculadora();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorDigitado = double.Parse(txtValor.Text);

            if (radioSomar.Checked == true)
            {
                calc.somar(valorDigitado);
            }
            else
            {
                calc.subtrair(valorDigitado);
            }

            lblValorTotal.Text = Convert.ToString(calc.Total);
            txtValor.Text = "";
        }
    }
}
