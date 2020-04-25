using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (radioBtnSenhor.Checked == true)
            {
                lblExibeTexto.Visible = true;

                if (cboPeriodo.Text == "Manhã")
                {
                    lblExibeTexto.Text = "Senhor, bom dia!";
                }
                else if (cboPeriodo.Text == "Tarde")
                {
                    lblExibeTexto.Text = "Senhor, boa tarde!";
                }
                else
                {
                    lblExibeTexto.Text = "Senhor, boa noite!";
                }
            }
            else if (radioBtnSenhora.Checked == true)
            {
                lblExibeTexto.Visible = true;

                if (cboPeriodo.Text == "Manhã")
                {
                    lblExibeTexto.Text = "Senhora, bom dia!";
                }
                else if (cboPeriodo.Text == "Tarde")
                {
                    lblExibeTexto.Text = "Senhora, boa tarde!";
                }
                else
                {
                    lblExibeTexto.Text = "Senhora, boa noite!";
                }
            }
            else
            {
                lblExibeTexto.Visible = true;

                if (cboPeriodo.Text == "Manhã")
                {
                    lblExibeTexto.Text = "Senhorita, bom dia!";
                }
                else if (cboPeriodo.Text == "Tarde")
                {
                    lblExibeTexto.Text = "Senhorita, boa tarde!";
                }
                else
                {
                    lblExibeTexto.Text = "Senhorita, boa noite!";
                }
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            radioBtnSenhor.Checked = false;
            radioBtnSenhora.Checked = false;
            radioBtnSenhorita.Checked = false;
            lblExibeTexto.Text = "";
            cboPeriodo.Text = "Selecione";
        }
    }
}
