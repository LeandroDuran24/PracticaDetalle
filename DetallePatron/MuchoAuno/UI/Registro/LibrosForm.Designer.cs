namespace MuchoAuno.UI.Registro
{
    partial class LibrosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label librosIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label edicionLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autoresComboBox = new System.Windows.Forms.ComboBox();
            this.librosIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.edicionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            autoresLabel = new System.Windows.Forms.Label();
            librosIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            edicionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Location = new System.Drawing.Point(6, 25);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(46, 13);
            autoresLabel.TabIndex = 7;
            autoresLabel.Text = "Autores:";
            // 
            // librosIdLabel
            // 
            librosIdLabel.AutoSize = true;
            librosIdLabel.Location = new System.Drawing.Point(154, 35);
            librosIdLabel.Name = "librosIdLabel";
            librosIdLabel.Size = new System.Drawing.Size(50, 13);
            librosIdLabel.TabIndex = 14;
            librosIdLabel.Text = "Libros Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(154, 61);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 16;
            nombreLabel.Text = "Nombre:";
            // 
            // edicionLabel
            // 
            edicionLabel.AutoSize = true;
            edicionLabel.Location = new System.Drawing.Point(154, 87);
            edicionLabel.Name = "edicionLabel";
            edicionLabel.Size = new System.Drawing.Size(45, 13);
            edicionLabel.TabIndex = 18;
            edicionLabel.Text = "Edicion:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(308, 302);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 23;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(135, 302);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(227, 302);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 21;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.autoresComboBox);
            this.groupBox1.Controls.Add(autoresLabel);
            this.groupBox1.Location = new System.Drawing.Point(111, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 152);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autores";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(196, 20);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 14;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(265, 97);
            this.dataGridView1.TabIndex = 0;
            // 
            // autoresComboBox
            // 
            this.autoresComboBox.FormattingEnabled = true;
            this.autoresComboBox.Location = new System.Drawing.Point(70, 22);
            this.autoresComboBox.Name = "autoresComboBox";
            this.autoresComboBox.Size = new System.Drawing.Size(121, 21);
            this.autoresComboBox.TabIndex = 8;
            // 
            // librosIdTextBox
            // 
            this.librosIdTextBox.Location = new System.Drawing.Point(218, 32);
            this.librosIdTextBox.Name = "librosIdTextBox";
            this.librosIdTextBox.Size = new System.Drawing.Size(31, 20);
            this.librosIdTextBox.TabIndex = 15;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(218, 58);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 17;
            // 
            // edicionTextBox
            // 
            this.edicionTextBox.Location = new System.Drawing.Point(218, 84);
            this.edicionTextBox.Name = "edicionTextBox";
            this.edicionTextBox.Size = new System.Drawing.Size(121, 20);
            this.edicionTextBox.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(librosIdLabel);
            this.Controls.Add(this.librosIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(edicionLabel);
            this.Controls.Add(this.edicionTextBox);
            this.Name = "LibrosForm";
            this.Text = "LibrosForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox autoresComboBox;
        private System.Windows.Forms.TextBox librosIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox edicionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}