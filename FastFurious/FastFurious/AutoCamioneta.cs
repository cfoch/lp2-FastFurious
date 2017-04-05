using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFurious
{
    public abstract class AutoCamioneta : Vehiculo
    {
        enum TransmisionTipo 
        {
            Automatico,
            Manual
        };

        private bool _conAireAcondicionado;
        private bool _conSistemaNavegacion;
        private bool _conEquipoTodoSonido;
        private bool _conControlInteligente;
        private TransmisionTipo _tipoTransmision;

        public AutoCamioneta(int codigo, string marca, string modelo, string color, int año, float precioAdquisicion, float precioVenta, EstadoTipo estado)
            : base (codigo, marca, modelo, color, año, precioAdquisicion, precioVenta, estado)
        {
            ConAireAcondicionado = false;
            ConSistemaNavegacion = false;
            ConEquipoTodoSonido = false;
            ConControlInteligente = false;
            TipoTransmision = TransmisionTipo.Manual;
        }

        public string ConsultarDatos()
        {
            string tipoTransmision, estado;

            // TODO
            // Esto deberia ser implementado como un metodo auxiliar
            tipoTransmision = TipoTransmision == TransmisionTipo.Automatico ? "Automatico" : "Manual";
            estado = Estado == EstadoTipo.EnVenta ? "E" : "V";

            return String.Format("{0} - {1} {2} ({3}) - {4} - Precio de venta: {5} - Estado: {6}", Codigo, Marca, Modelo, Año, tipoTransmision,
                PrecioVenta, estado);
        }

        public bool ConAireAcondicionado
        {
            get { return _conAireAcondicionado; }
            set { _conAireAcondicionado = value; }
        }

        public bool ConSistemaNavegacion
        {
            get { return _conSistemaNavegacion; }
            set { _conSistemaNavegacion = value; }
        }

        public bool ConEquipoTodoSonido
        {
            get { return _conEquipoTodoSonido; }
            set { _conEquipoTodoSonido = value; }
        }

        public bool ConControlInteligente
        {
            get { return _conControlInteligente; }
            set { _conControlInteligente = value; }
        }

        private TransmisionTipo TipoTransmision
        {
            get { return _tipoTransmision; }
            set { _tipoTransmision = value; }
        }
    }
}
