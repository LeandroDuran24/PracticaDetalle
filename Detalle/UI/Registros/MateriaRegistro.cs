using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detalle.UI.Registros
{
    public partial class MateriaRegistro : Form
    {
        public MateriaRegistro()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            materiaIdTextBox.Clear();
            nombreTextBox.Clear();
            nombreTextBox.Focus();
        }

        public bool Validar()
        {
            if(string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProviderNombre.SetError(nombreTextBox, "Campo Vacio");
                return false;
            }
            return true;
        }



        private void MateriaRegistro_Load(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var guardar = new Entidades.Materias();
           if(!Validar())
            {
                MessageBox.Show("Llene los campos");

            }
            else
            {

                guardar.MateriaId = Utilidades.TOIN(materiaIdTextBox.Text);
                guardar.Nombre = nombreTextBox.Text;
                if(BLL.MateriaBLL.Guardar(guardar))
                {
                    MessageBox.Show("Guardado COn exito");
                }else
                {
                    MessageBox.Show("error");
                }
                Limpiar();

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var buscar = BLL.MateriaBLL.Buscar(Utilidades.TOIN(materiaIdTextBox.Text));
            if(buscar != null)
            {
                nombreTextBox.Text = buscar.Nombre;
                MessageBox.Show("Busqueda");
            }
            else
            {
                MessageBox.Show("Error");
            }
                }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
