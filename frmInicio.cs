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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btDocentes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocentes docentes = new frmDocentes();
            docentes.Show();
            
        }

        private void btAlumnos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.Show();

        }
    }
}
