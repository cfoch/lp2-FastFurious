using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    public class Sucursal
    {
        private string _distrito;
        private string _direccion;
        private BindingList<Vehiculo> _vehiculos;
        private BindingList<Empleado> _empleados;

        public Sucursal(string distrito, string direcion)
        {
            Distrito = distrito;
            Direccion = direcion;
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            _vehiculos.Add(vehiculo);
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public string ObtenerNombre()
        {
            return String.Format("F&F {0}", Distrito);
        }

        // Propiedades

        public string Distrito
        {
            get { return _distrito; }
            set { _distrito = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public BindingList<Vehiculo> Vehiculos
        {
            get { return _vehiculos; }
        }

        public BindingList<Empleado> Empleados
        {
            get { return _empleados; }
        }
    }
}
