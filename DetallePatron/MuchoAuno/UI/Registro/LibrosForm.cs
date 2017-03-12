using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MuchoAuno.Entidades;

namespace MuchoAuno.UI.Registro
{
    public partial class LibrosForm : Form
    {
        public LibrosForm()
        {
            InitializeComponent();
            Limpiar();
            LLenarCombo();
        }

        Entidades.Libros libro;
        public void Limpiar()
        {
            nombreTextBox.Clear();
            librosIdTextBox.Clear();
            edicionTextBox.Clear();
            autoresComboBox.Text = null;
            errorProvider1.Clear();

            dataGridView1.DataSource = null;
            libro = new Libros();
        }


        public bool Validar()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Favor llenar");
                return false;
            }
            else
            if (string.IsNullOrEmpty(edicionTextBox.Text))
            {
                errorProvider1.SetError(edicionTextBox, "Favor Llenar");
                return false;
            }

            else
            if (string.IsNullOrEmpty(autoresComboBox.Text))
            {
                errorProvider1.SetError(autoresComboBox, "Favor Llenar");
                return false;
            }
            return true;
        }

        public void LLenarDataGrid(Libros nuevo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nuevo.autorList;
        }

        public void LLenarCombo()
        {
            List<Autores> lista = BLL.AutoreBLL.GetLisTodo();
            autoresComboBox.DataSource = lista;
            autoresComboBox.DisplayMember = "Nombre";
            autoresComboBox.ValueMember = "AutoresId";


            if (autoresComboBox.Items.Count > 0)
                autoresComboBox.SelectedIndex = -1;
        }

        public Libros LlenarCampos()
        {
            libro.Nombre = nombreTextBox.Text;
            libro.Edicion = Utilidades.TOINT(edicionTextBox.Text);
            libro.Autores = autoresComboBox.Text;
            libro.LibrosId = Utilidades.TOINT(librosIdTextBox.Text);
            libro.AutoresId = Utilidades.TOINT(autoresComboBox.SelectedValue.ToString());
            return libro;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
            using (var db = new DAL.Repositorio<Libros>())
            {
                if(id != libro.LibrosId)
                {
                    db.Mdificar(libro);
                    MessageBox.Show("Modificado");
                }
                else
                {
                    libro = LlenarCampos();
                    if (BLL.LibroBLL.Guardar(libro))
                        MessageBox.Show("Correcto");
                    else
                        MessageBox.Show("Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(librosIdTextBox.Text);

            using (var db = new DAL.Repositorio<Libros>())
            {
                libro = db.Buscar(p => p.LibrosId == id);

                if (libro != null)
                {
                    nombreTextBox.Text = libro.Nombre;
                    edicionTextBox.Text = Convert.ToString(libro.Edicion);
                    autoresComboBox.SelectedValue = libro.Autores;
                    //LLenarDataGrid(libro);
                    MessageBox.Show("Correcto");
                }
                else
                    MessageBox.Show("No existe");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(librosIdTextBox.Text);
            using (var db = new DAL.Repositorio<Libros>())
            {
                if (db.Eliminar(db.Buscar(p => p.LibrosId == id)))
                    MessageBox.Show("Correcto");
                else
                    MessageBox.Show("error");
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Autores autor = new Autores();

            autor = (Autores)autoresComboBox.SelectedItem;
            libro.autorList.Add(autor);
            LLenarDataGrid(libro);
        }
    }
}
