using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Detalle2.Entidades;

namespace Detalle2.UI.Registros
{
    public partial class AutoresForm : Form
    {
        public AutoresForm()
        {
            InitializeComponent();
        }


        private void Autores_Load(object sender, EventArgs e)
        {

        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Favor llenar");
                return false;
            }
            return true;
        }

        public void Limpiar()
        {
            nombreTextBox.Clear();
            autoresIdTextBox.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var guarda = new Autores();

            if(!Validar())
            {
                MessageBox.Show("Favor llenar");
            }
            else
            {
                guarda.AutoresId = Utilidades.TOINT(autoresIdTextBox.Text);
                guarda.Nombre = nombreTextBox.Text;

                if (BLL.AutoresBLL.Guardar(guarda))
                    MessageBox.Show("Se ha Guardado");
                else
                    MessageBox.Show("Error");

                Limpiar();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var busca = BLL.AutoresBLL.Buscar(Utilidades.TOINT(autoresIdTextBox.Text));

            if (busca != null)
            {
                nombreTextBox.Text = busca.Nombre;
                MessageBox.Show("Correcto");
            }
            else
                MessageBox.Show("No existe");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var elimina = BLL.AutoresBLL.Buscar(Utilidades.TOINT(autoresIdTextBox.Text));
            if (elimina != null)
            {
                if (BLL.AutoresBLL.Eliminar(elimina))
                    MessageBox.Show("Correcto");
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Error");
        }
    }
}
