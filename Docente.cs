using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Docente
    {
        #region Atributos
        private string nombre;
        private long dni;
        private DateTime fechNac;
        private char sexo;
        private string materia;
        private string legajo;
        #endregion

        #region Propiedades

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public long Dni
        {
            set { dni = value; }
            get { return dni; }
        }
        public DateTime FechNac
        {
            set { fechNac = value; }
            get { return fechNac; }
        }
        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public string Materia
        {
            set { materia = value; }
            get { return materia; }
        }

        public string Legajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        #endregion

        #region Constructores
        public Docente()
        {
        }
        public Docente(string Nom, long dni, DateTime Fechnac, char sex)
        {
            Nombre = Nom;
            Dni = dni;
            FechNac = Fechnac;
            Sexo = sex;
        }
        public Docente(string Nom, long dni, DateTime Fechnac, char sex, string materia, string legajo)
        {
            Nombre = Nom;
            Dni = dni;
            FechNac = Fechnac;
            Sexo = sex;
            Materia = materia;
            Legajo = legajo;
        }

        #endregion

        #region Metodos

        public int Edad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechNac.Year;
            if (fechaActual < fechNac.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }
        #endregion
    }
}

