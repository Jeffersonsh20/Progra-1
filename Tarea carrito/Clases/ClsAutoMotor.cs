using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_carrito.Clases
{
    class ClsAutoMotor
    {
        public string marca { get; set; }
        public int vel_max { get; set; }
        public string color { get; set; }
        public int VelocidadActual { get; set; }

        public bool encendido { get; set; } = false; 


        public string encender()
        {
            if (encendido)
            {
                return "Lo siento el Carro ya esta encendido";
            }else
            {
                VelocidadActual = 0;
                encendido = true;
                return "Listo, pon Waze para que no te pierdad";
            }
        }
    }
}
