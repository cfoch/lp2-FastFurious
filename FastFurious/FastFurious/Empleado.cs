using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    public class Empleado : Persona
    {
        private string _cargo;

        public Empleado(string nombre, string apellido, int dni, int edad, string nacionalidad,
            string telefono, string direccion, string cargo, string email = null, string lugarNacimiento = null)
            : base (nombre, apellido, dni, edad, nacionalidad, telefono, direccion)
        {
            Cargo = cargo;
            Email = email;
            LugarNacimiento = lugarNacimiento;
        }

        string ConsultarDatos()
        {
            return String.Format("{0} - {1} {2} - {3}", DNI, Nombre, Apellido, Cargo);
        }

        // Propiedades

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }


    }
}
