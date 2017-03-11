using Detalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Detalle.UI.Consultas;

namespace Detalle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriaRegistro db = new MateriaRegistro();
            db.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroEstudiante db = new UI.Registros.RegistroEstudiante();
            db.Show();
        }

        private void estudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.Show();
        }
    }
}
