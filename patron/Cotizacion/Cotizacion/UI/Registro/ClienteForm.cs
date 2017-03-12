using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cotizacion.Entidades;

namespace Cotizacion.UI.Registro
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            Limpiar();
           
        }
        Clientes cliente;
        private void ClienteForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        public void Limpiar()
        {
            clienteIdTextBox.Clear();
            nombreTextBox.Clear();
            direccionTextBox.Clear();

            dataGridView1.DataSource = null;
            cliente = new Clientes();
        }

        public Clientes LLenarCampos()
        {
            cliente.ClienteId = Utilidades.TOINT(clienteIdTextBox.Text);
            cliente.Nombre = nombreTextBox.Text;
            cliente.Direccion = direccionTextBox.Text;
            cliente.Producto = productoComboBox.Text;
            cliente.ProductoId=Utilidades.TOINT(productoComboBox.SelectedValue.ToString());
            return cliente;
          
        }

        public void LLenarData(Clientes nuevo)
        {
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nuevo.productoList;
        }

        public void LlenarCombo()
        {
            List<Entidades.Produtos> list = BLL.ProductoBLL.GetListTodo();
            productoComboBox.DataSource = list;
            productoComboBox.DisplayMember = "Nombre";
            productoComboBox.ValueMember = "ProductoId";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 0;
            using (var db = new DAL.Repositorio<Clientes>())
            {
                cliente = LLenarCampos();
                if(id!= cliente.ClienteId)
                {
                    db.Modificar(cliente);
                    MessageBox.Show("Correcto");
                }
                else
                {
                    if (BLL.ClienteBLL.Guardar(cliente))
                        MessageBox.Show("Correcto");
                    else
                        MessageBox.Show("Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(clienteIdTextBox.Text);
            using (var db = new DAL.Repositorio<Clientes>())
            {
                cliente = db.Buscar(p => p.ClienteId == id);

                if (cliente != null)
                {
                    nombreTextBox.Text = cliente.Nombre;
                    direccionTextBox.Text = cliente.Direccion;
                    productoComboBox.Text = cliente.Producto;
                    MessageBox.Show("Correcto");
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(clienteIdTextBox.Text);
            using (var db = new DAL.Repositorio<Clientes>())
            {
                if (db.Eliminar(db.Buscar(p => p.ClienteId == id)))
                    MessageBox.Show("Correcto");
                else
                    MessageBox.Show("Error");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produtos product = new Produtos();
            product = (Produtos)productoComboBox.SelectedItem;

            cliente.productoList.Add(product);
            LLenarData(cliente);
        }
    }
}
