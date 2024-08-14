using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaltarEntreFormularios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Crear una nueva fila en el grid
            int fila = dataGridView1.Rows.Add();

            dataGridView1.Rows[fila].Cells[0].Value = txtPass.Text;
            dataGridView1.Rows[fila].Cells[1].Value = txtNombre.Text;
            dataGridView1.Rows[fila].Cells[2].Value = txtsueldo.Text;
            this.guardadatos();
        }

        private void guardadatos()
        {
            MessageBox.Show("Datos guardados correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtPass.Text = null;
            txtNombre.Text = null;
            txtsueldo.Text = null;

            txtPass.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtPass.Text = null;
            txtNombre.Text = null;
            txtsueldo.Text = null;

            txtPass.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Password = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String Nombres = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String Sueldos = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            MessageBox.Show("La claves es: "+ Password + ", El Nombre es: "+ Nombres +" y su sueldo es: "+ Sueldos);
        }
    }

}

