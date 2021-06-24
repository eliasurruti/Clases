using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Alumno
    {
        #region Atributos
        private string nombre;
        private long dni;
        private DateTime fechNac;
        private char sexo;
        private string carrera;
        private long legajo;
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
        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public string Carrera
        {
            set { carrera = value; }
            get { return carrera; }
        }
        public long Legajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        public DateTime FechNac
        {
            set { fechNac = value; }
            get { return fechNac; }
        }

        #endregion

        #region Constructores

        public Alumno()
        {

        }
        public Alumno(string Nom, long dni, DateTime fechNac, char sex)
        {
            Nombre = Nom;
            Dni = dni;
            FechNac = fechNac;
            Sexo = sex;
        }
        public Alumno(string Nom, long Dni, DateTime fechNac, char sex, string carrera, long legajo)
        {
            Nombre = Nom;
            Dni = dni;
            FechNac = fechNac;
            Sexo = sex;
            Carrera = carrera;
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

