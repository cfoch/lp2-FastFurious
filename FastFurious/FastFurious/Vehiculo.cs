using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    public class Vehiculo : IConsultable
    {
        public enum EstadoTipo
        {
            EnVenta,
            Vendido
        };

        private int _codigo;
        private string _marca;
        private string _modelo;
        private string _color;
        private int _año;
        private float _precioAdquisicion;
        private float _precioVenta;
        private EstadoTipo _estado;

        public Vehiculo(int codigo, string marca, string modelo, string color, int año, float precioAdquisicion, float precioVenta, EstadoTipo estado)
        {
            _codigo = codigo;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Año = año;
            PrecioAdquisicion = precioAdquisicion;
            PrecioVenta = precioVenta;
            Estado = estado;
        }

        public string ConsultarDatos()
        {
            return String.Format("{0} - {1} {2} ({3})", Codigo, Marca, Modelo, Año);
        }

        public int Codigo
        {
            get { return _codigo; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Año
        {
          get { return _año; }
          set { _año = value; }
        }

        public float PrecioAdquisicion
        {
            get { return _precioAdquisicion; }
            set { _precioAdquisicion = value; }
        }

        public float PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public EstadoTipo Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }


    }
}
