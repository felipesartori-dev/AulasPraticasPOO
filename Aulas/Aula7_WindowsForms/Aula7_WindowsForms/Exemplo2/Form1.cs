using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String sobrenome = txtSobrenome.Text;
            String cidade = txtCidade.Text;

            MessageBox.Show($"Olá {nome} {sobrenome}\nCidade: {cidade}", "Aviso");
        }
    }
}
