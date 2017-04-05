using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    class MotoLineal : Vehiculo
    {
        public enum ArranqueTipo
        {
            Electrico,
            Pedal
        };

        private double _potencia;
        private int _numeroVelocidades;
        private ArranqueTipo _tipoArranque;

        public MotoLineal(int codigo, string marca, string modelo, string color, int año, float precioAdquisicion, float precioVenta, EstadoTipo estado)
            : base (codigo, marca, modelo, color, año, precioAdquisicion, precioVenta, estado)
        {
            Potencia = 0.0;
            NumeroVelocidades = 1;
            TipoArranque = ArranqueTipo.Pedal;
        }

        // Propiedades

        public double Potencia
        {
            get { return _potencia; }
            set { _potencia = value; }
        }

        public int NumeroVelocidades
        {
            get { return _numeroVelocidades; }
            set { _numeroVelocidades = value; }
        }

        public ArranqueTipo TipoArranque
        {
            get { return _tipoArranque; }
            set { _tipoArranque = value; }
        }


    }
}
