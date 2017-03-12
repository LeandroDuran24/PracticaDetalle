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
    public partial class AutoresForm : Form
    {
        public AutoresForm()
        {
            InitializeComponent();
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
            Autores autor = new Autores();
            int id = 0;

            using (var db = new DAL.Repositorio<Entidades.Autores>())
            {
                if (!Validar())
                {
                    MessageBox.Show("Favor llenar");
                }
                else
                {
                    autor.AutoresId = Utilidades.TOINT(autoresIdTextBox.Text);
                    autor.Nombre = nombreTextBox.Text;
                    if (id != autor.AutoresId)
                    {
                        db.Mdificar(autor);
                        MessageBox.Show("Se ha Modificado");
                    }
                    else
                    {
                        if (BLL.AutoreBLL.Guardar(autor))
                            MessageBox.Show("Correcto");
                        else
                            MessageBox.Show("Error");
                    }

                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(autoresIdTextBox.Text);
            Autores autor = new Autores();
            using (var db = new DAL.Repositorio<Entidades.Autores>())
            {
                autor = db.Buscar(p=> p.AutoresId ==id);

                if(autor!=null)
                {
                    nombreTextBox.Text = autor.Nombre;
                    MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("No existe");
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(autoresIdTextBox.Text);


            using (var db = new DAL.Repositorio<Autores>())
            {
                if(db.Eliminar(db.Buscar(p=> p.AutoresId==id)))
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
