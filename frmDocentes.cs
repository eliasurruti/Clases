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
    public partial class frmDocentes : Form
    {
        Docente docente = new Docente();
        int posicion;
        public frmDocentes()
        {
            
            InitializeComponent();
        }
        void limpiarcontroles()
        {
            txtNombreDoc.Text = "";
            txtDniDoc.Text = "";
            txtLegajoDoc.Text = "";
            dateTimeFechNacDoc.Value = DateTime.Now;

            if (rbSexoDoc.Checked == true)
            {
                rbSexoDoc.Checked = false;
            }
            if (rbSexo2Doc.Checked == true)
            {
                rbSexo2Doc.Checked = false;
            }
            if (rbSexo3Doc.Checked == true)
            {
                rbSexo3Doc.Checked = false;
            }

        }
        private void btCargarDoc_Click(object sender, EventArgs e)
        {
            try
            {
                docente.Nombre = txtNombreDoc.Text;
                docente.Dni = Convert.ToInt64(txtDniDoc.Text);
                docente.FechNac = dateTimeFechNacDoc.Value;

                docente.Legajo = txtLegajoDoc.Text;
                if (rbSexoDoc.Checked == true)
                {
                    docente.Sexo = Convert.ToChar("M");
                }
                if (rbSexo2Doc.Checked == true)
                {
                    docente.Sexo = Convert.ToChar("F");
                }
                if (rbSexo3Doc.Checked == true)
                {
                    docente.Sexo = Convert.ToChar("O");
                }

                dataGridViewDoc.Rows.Add(docente.Nombre, docente.Dni, docente.Sexo, docente.Edad(), docente.Legajo);

            }
            catch (Exception)
            {
                MessageBox.Show("Complete los campos vacios");
                
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Desea borrar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (rta == DialogResult.Yes)
            {
                posicion = dataGridViewDoc.CurrentRow.Index;
                if (dataGridViewDoc.SelectedRows.Count == 0)
                {
                    DialogResult registrovacio = MessageBox.Show("El registo que desea borrar esta vacio");
                }
                else
                {
                    dataGridViewDoc.Rows.RemoveAt(posicion);
                }
                
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
