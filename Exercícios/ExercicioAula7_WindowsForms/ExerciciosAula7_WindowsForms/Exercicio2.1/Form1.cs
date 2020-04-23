using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cor1 = random.Next(0, 255);
            int cor2 = random.Next(0, 255);
            int cor3 = random.Next(0, 255);

            this.BackColor = Color.FromArgb(cor1, cor2, cor3);
        }
    }
}
