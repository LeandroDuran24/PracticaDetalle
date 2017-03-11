using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Detalle2.UI.Consultas;
using Detalle2.UI.Registros;

namespace Detalle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresForm af = new AutoresForm();
            af.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrosForm lf = new LibrosForm();
            lf.Show();
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }
    }
}
