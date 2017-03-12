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
    public partial class ProductoForm : Form
    {
        Produtos product;
        public ProductoForm()
        {
            InitializeComponent();


        }



        private void ProductoForm_Load(object sender, EventArgs e)
        {


        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Favor LLenar");
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            nombreTextBox.Clear();
            errorProvider1.Clear();
            productoIdTextBox.Clear();
            product = new Produtos();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int id = 0;
            Produtos producto = new Produtos();
            using (var db = new DAL.Repositorio<Produtos>())
            {
                if (!Validar())
                {
                    MessageBox.Show("Favor llenar");
                }
                else
                {

                    producto.ProductoId = Utilidades.TOINT(productoIdTextBox.Text);
                    producto.Nombre = nombreTextBox.Text;
                     if (id != producto.ProductoId)
                     {
                         db.Modificar(producto);
                         MessageBox.Show("Modificado");
                     }
                     else
                     {
                    if (BLL.ProductoBLL.Guardar(producto))
                        MessageBox.Show("Correcto");
                    else
                        MessageBox.Show("error");

                    }

                }
                Limpiar();
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(productoIdTextBox.Text);

            using (var db = new DAL.Repositorio<Produtos>())
            {
                product = db.Buscar(p => p.ProductoId == id);

                if (product != null)
                {
                    nombreTextBox.Text = product.Nombre;
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("No existe");
                }
            }


        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(productoIdTextBox.Text);

            using (var db = new DAL.Repositorio<Produtos>())
            {
                if (db.Eliminar(db.Buscar(p => p.ProductoId == id)))
                {
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
