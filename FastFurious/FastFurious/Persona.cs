using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    public class Persona : IConsultable
    {
        private string _nombre;
        private string _apellido;
        private int _DNI;
        private int _edad;
        private string _nacionalidad;
        private string _email;
        private string _telefono;
        private string _direccion;
        private string _lugarNacimiento;

        public Persona(string nombre, string apellido, int dni, int edad, string nacionalidad,
            string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Telefono = telefono;
            Direccion = direccion;
        }

        public string ConsultarDatos()
        {
            return String.Format("{0} - {1} {2} - {3}", DNI, Nombre, Apellido);
        }

        // Propiedades

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefono
        {
          get { return _telefono; }
          set { _telefono = value; }
        }

        public string Direccion
        {
          get { return _direccion; }
          set { _direccion = value; }
        }

        public string LugarNacimiento
        {
            get { return _lugarNacimiento; }
            set { _lugarNacimiento = value; }
        }

    }
}
