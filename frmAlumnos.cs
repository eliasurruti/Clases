using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class frmAlumnos : Form
    {
        int posicion;
        Alumno alumno = new Alumno();
        public frmAlumnos()
        {
            InitializeComponent();
        }
        void limpiarcontroles()
        {
            txtNombreAlu.Text = "";
            txtDniAlu.Text = "";
            txtLegajoAlu.Text = "";
            dateTimeFechNacAlu.Value = DateTime.Now;

            if (rbSexoAlu.Checked == true)
            {
                rbSexoAlu.Checked = false;
            }
            if (rbSexo2Alu.Checked == true)
            {
                rbSexo2Alu.Checked = false;
            }
            if (rbSexo3Alu.Checked == true)
            {
                rbSexo3Alu.Checked = false;
            }

        }
        private void btCargarAlu_Click(object sender, EventArgs e)
        {
            try
            {
                alumno.Nombre = txtNombreAlu.Text;
                alumno.Dni = Convert.ToInt64(txtDniAlu.Text);
                alumno.FechNac = dateTimeFechNacAlu.Value;
                alumno.Legajo = Convert.ToInt64(txtLegajoAlu.Text);
                alumno.Carrera = cbCarrerasAlu.SelectedItem.ToString();

                if (rbSexoAlu.Checked == true)
                {
                    alumno.Sexo = Convert.ToChar("M");
                }
                if (rbSexo2Alu.Checked == true)
                {
                    alumno.Sexo = Convert.ToChar("F");
                }
                if (rbSexo3Alu.Checked == true)
                {
                    alumno.Sexo = Convert.ToChar("O");
                }

                dataGridViewAlu.Rows.Add(alumno.Nombre, alumno.Dni, alumno.Sexo, alumno.Edad(), alumno.Carrera, alumno.Legajo);
            }
            catch (Exception)
            {
                MessageBox.Show("Complete los campos vacios");
            }
        }

        private void btNuevoAlu_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void btBorrarAlu_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Desea borrar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (rta == DialogResult.Yes)
            {
                posicion = dataGridViewAlu.CurrentRow.Index;
                if (dataGridViewAlu.SelectedRows.Count == 0)
                {
                    DialogResult registrovacio = MessageBox.Show("El registo que desea borrar esta vacio");
                }
                else
                {
                    dataGridViewAlu.Rows.RemoveAt(posicion);
                }

            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
