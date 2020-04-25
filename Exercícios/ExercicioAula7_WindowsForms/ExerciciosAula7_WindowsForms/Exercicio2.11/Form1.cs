using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAgenda.ColumnCount = 7;
            dgvAgenda.Columns[0].Name = "Domingo";
            dgvAgenda.Columns[1].Name = "Segunda";
            dgvAgenda.Columns[2].Name = "Terça";
            dgvAgenda.Columns[3].Name = "Quarta";
            dgvAgenda.Columns[4].Name = "Quinta";
            dgvAgenda.Columns[5].Name = "Sexta";
            dgvAgenda.Columns[6].Name = "Sábado";

            string[] row1 = new string[7];
            row1[3] = ("1"); 
            row1[4] = ("2"); 
            row1[5] = ("3"); 
            row1[6] = ("4");

            string[] row2 = new string[7];
            row2[0] = ("5");
            row2[1] = ("6");
            row2[2] = ("7");
            row2[3] = ("8");
            row2[4] = ("9");
            row2[5] = ("10");
            row2[6] = ("11");

            string[] row3 = new string[7];
            row3[0] = ("12");
            row3[1] = ("13");
            row3[2] = ("14");
            row3[3] = ("15");
            row3[4] = ("16");
            row3[5] = ("17");
            row3[6] = ("18");

            string[] row4 = new string[7];
            row4[0] = ("19");
            row4[1] = ("20");
            row4[2] = ("21");
            row4[3] = ("22");
            row4[4] = ("23");
            row4[5] = ("24");
            row4[6] = ("25");

            string[] row5 = new string[7];
            row5[0] = ("26");
            row5[1] = ("27");
            row5[2] = ("28");
            row5[3] = ("29");
            row5[4] = ("30");

            dgvAgenda.Rows.Add(row1);
            dgvAgenda.Rows.Add(row2);
            dgvAgenda.Rows.Add(row3);
            dgvAgenda.Rows.Add(row4);
            dgvAgenda.Rows.Add(row5);
        }
    }
}
