﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detalle.UI.Consultas
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

      

        private void Consulta_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.EstudianteBLL.GetListodo();
        }
    }
}
