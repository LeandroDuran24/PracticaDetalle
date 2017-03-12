using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MuchoAuno.UI.Registro;

namespace MuchoAuno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoresForm a = new AutoresForm();
            a.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibrosForm lf = new LibrosForm();
            lf.Show();
        }
    }
}
