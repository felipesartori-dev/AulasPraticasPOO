using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Alguém me clicou, OK");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Random r = new Random();
            int vermelho = r.Next(0, 255);
            int verde = r.Next(0, 255);
            int azul = r.Next(0, 255);

            this.BackColor = Color.FromArgb(vermelho, verde, azul);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            label2.Text = txt.Text;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txt.Clear();
        }
    }
}
