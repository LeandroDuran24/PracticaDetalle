using System;
using System.Windows.Forms;
using Cotizacion.UI.Consultas;
using Cotizacion.UI.Registro;

namespace Cotizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoForm pf = new ProductoForm();
            pf.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cf = new ClienteForm();
            cf.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes c = new ConsultaClientes();
            c.Show();
        }
    }
}
