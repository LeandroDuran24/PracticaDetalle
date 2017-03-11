using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Detalle.Entidades;

namespace Detalle.UI.Registros
{
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
            Limpiar();
        }

        Entidades.Estudiantes student;

        private void Limpiar()
        {
            nombreTextBox.Clear();
            carreraTextBox.Clear();
            estudianteIdTextBox.Clear();
            nombreTextBox.Focus();
            errorProvider1.Clear();

            dataGridView1.DataSource = null;
            student = new Entidades.Estudiantes();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Campo Vacio");
                retorno = false;
            }
            if (string.IsNullOrWhiteSpace(carreraTextBox.Text))
            {
                errorProvider1.SetError(carreraTextBox, "Campo Vacio");
                retorno = false;
            }
            return retorno;
            
        }

        public void llenarCombo()
        {
            List<Entidades.Materias> lista = BLL.MateriaBLL.GetListodo();
            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "MateriaId";

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = -1;
        }

        private void llenarData(Entidades.Estudiantes n)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = n.MateriaList;
        }

        private void RegistroEstudiante_Load(object sender, EventArgs e)
        {
            llenarCombo();

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            var guardar = new Entidades.Estudiantes();
            guardar.Nombre = nombreTextBox.Text;
            guardar.Carrera = carreraTextBox.Text;
            guardar.EstudianteId = Utilidades.TOIN(estudianteIdTextBox.Text);
            guardar.Materia = comboBox1.Text;
            guardar.MateriaId = Utilidades.TOIN(comboBox1.SelectedValue.ToString());

            if (BLL.EstudianteBLL.Guardar(guardar))

                MessageBox.Show("Guardado");


            else

                MessageBox.Show("Error");

            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Materias materia = new Entidades.Materias();
            materia = (Entidades.Materias)comboBox1.SelectedItem;// Combo
            student.MateriaList.Add(materia);// Llama la lista 
            llenarData(student);//LLena el grip
        }

       

        private void searchButton_Click(object sender, EventArgs e)
        {
           student = BLL.EstudianteBLL.Buscar(Utilidades.TOIN(estudianteIdTextBox.Text));

            if(student!=null)
            {
                nombreTextBox.Text = student.Nombre;
                carreraTextBox.Text = student.Carrera;
                comboBox1.SelectedValue = student.Materia;
                //llenarData(student);
                MessageBox.Show("Correcto");

            }
            else
            {
                MessageBox.Show("No existe");
            }
        }
    }
}
