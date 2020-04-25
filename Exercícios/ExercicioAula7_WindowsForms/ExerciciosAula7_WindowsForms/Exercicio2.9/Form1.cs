using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._9
{
    public partial class Form1 : Form
    {
        Bitmap imagem;

        public Form1()
        {
            InitializeComponent();
            imagem = new Bitmap(300, 300);
        }

        private void imagemPbx_MouseDown(object sender, MouseEventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    imagem.SetPixel(e.X + x, e.Y + y, Color.Red);
                }
            }
            imagemPbx.Image = imagem;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            imagem.Save("C:\\Windows\\Temp\\saida.gif", System.Drawing.Imaging.ImageFormat.Gif);
            MessageBox.Show("Imagem salva com sucesso em c:\\Temp\\saida.gif", "Sucesso");
        }
    }
}
