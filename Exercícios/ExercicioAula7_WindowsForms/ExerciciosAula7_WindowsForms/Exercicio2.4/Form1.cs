using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            lblTexto.Text = txbNome.Text;
            lblTexto.Visible = true;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            lblTexto.Text = "";
            lblTexto.Visible = false;
            txbNome.Text = "";
        }
    }
}
