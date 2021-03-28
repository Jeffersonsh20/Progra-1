using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_carrito.Class
{
    class ClsAutoMotor
    {
        public string marca { get; }
        public int vel_max { get; }
        public string color { get; set; }
        private int velocidadActual = 0;

        public bool encendido { get; set; } = false;



        public ClsAutoMotor(string marcaCarro, int MaxVel)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
        }



        public ClsAutoMotor(string marcaCarro, int MaxVel, string colorCarro)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
            this.color = colorCarro;
        }

        public string encender()
        {
            string respuesta = "";
            if (encendido)
            {

                encendido = false;
                respuesta= "Ahora el carro esta apagado";
            }else
            {

                encendido = true;
                respuesta= "Listo; pon waze para que no te pierdas";
            }

            velocidadActual = 0;
            return respuesta;

        }



        public string DetenerMarcha()
        {
            if (!encendido)
            {
                return "Enciende el carro Primero!";
            }

            velocidadActual = 0;
            return "Auto Detenido";

        }


        public string Xvelocidad()
        {
            string velocidad = "";
            if (velocidadActual == 0)
            {
                velocidad = "1";
            }
            if (velocidadActual == 30)
            {
                velocidad = "2";

            }
            else if (velocidadActual == 40)
            {
                velocidad = "3";

            }
            else if (velocidadActual == 50)
            {
                velocidad = "4";

            }
            else if (velocidadActual == 90)
            {
                velocidad = "5";
            }
            return velocidad;


        }
        public bool cambios()
        {
            bool cambio;
            switch (velocidadActual)
            {
                case 20:
                case 30:
                case 40:
                case 80:
                    cambio = false;
                    break;
                default:
                    cambio = true;
                    break;
            }
            return cambio;
        }



        public string Acelerar()
        {
            if (!encendido)
            {
                return "Enciende el carro Primero!";
            }

            if (velocidadActual > vel_max)
            {
                velocidadActual = vel_max;
                return $"Hey Tranquilo, ya llegaste al tope {vel_max} KPH";
            }
            else
            {
                velocidadActual = velocidadActual + 10;
                return $"Vas a {velocidadActual} KPH";
                
            }

        }
    }
}
