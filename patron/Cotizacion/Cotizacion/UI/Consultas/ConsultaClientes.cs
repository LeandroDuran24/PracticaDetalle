using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cotizacion.UI.Consultas
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }


        private void ConsultaClientes_Load(object sender, EventArgs e)
        {

            LLenarCombo();
        }

        public void LLenarCombo()
        {
            comboBox1.Items.Insert(0, "Todos");
            comboBox1.Items.Insert(1, "Nombre");
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Todos";

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                clientesDataGridView.DataSource = BLL.ClienteBLL.GetListTodo();

            else
            if (comboBox1.SelectedIndex == 1)
                clientesDataGridView.DataSource = BLL.ClienteBLL.GetList(p => p.Nombre == textBox1.Text);

        }
    }
}
