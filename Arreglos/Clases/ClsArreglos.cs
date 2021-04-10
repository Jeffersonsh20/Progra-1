using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int j, a, datosTemporal;
        private int tamanoArreglo = 0;


        public int GetTamanoArreglo()
        {
            return datos.Length;
        }


        public ClsArreglos(int[] arreglosParametro)
        {
            datos = arreglosParametro;
            tamanoArreglo = datos.Length;
        }


        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for(j = 0; j < tamanoArreglo - 1; j++)
            {
                for(a=j+1; a < tamanoArreglo; a++)
                {
                    if(ArregloTemporal[j] < ArregloTemporal[a])
                    {

                        datosTemporal = ArregloTemporal[j];
                        ArregloTemporal[j] = ArregloTemporal[a];
                        ArregloTemporal[a] = datosTemporal;

                    }

                }
            }

            return ArregloTemporal;
        }


    }
}
