using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    public class Auto : AutoCamioneta
    {
        public Auto(int codigo, string marca, string modelo, string color, int año, float precioAdquisicion, float precioVenta, EstadoTipo estado)
            : base (codigo, marca, modelo, color, año, precioAdquisicion, precioVenta, estado)
        {

        }
    }
}
