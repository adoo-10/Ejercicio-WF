using NotasCiclo.Entidades;
using NotasCiclo.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasCiclo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M_Entidades ent = new M_Entidades();
            ent.Lab = Convert.ToDouble(TxtLab.Text);
            ent.Parcial = Convert.ToDouble(TxtParcial.Text);
            ent.Lab2 = Convert.ToDouble(TxtLab2.Text);
            ent.Parcial2 = Convert.ToDouble(TxtParcial2.Text);
            ent.Lab3 = Convert.ToDouble(TxtLab3.Text);
            ent.Parcial3 = Convert.ToDouble(TxtParcial3.Text);

            M_Negocios negocios = new M_Negocios();
            MessageBox.Show(negocios.calculoCiclo(ent));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
