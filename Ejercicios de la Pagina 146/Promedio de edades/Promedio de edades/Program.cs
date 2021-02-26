using System;

namespace EDADES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte k;
            byte j;
            byte h = 0;
            byte t = 0;
            byte a;
            Console.Write("Ingrese la cantidad de edades: ");
            j = byte.Parse(Console.ReadLine());
            for (a = 0; a < j; a++)
            {
                Console.Write("Ingrese una Edad: ");
                k = byte.Parse(Console.ReadLine());
                if (a == 0)
                {
                    t = k;
                    h = k;
                }
                else if (a != 0)
                {
                    if (k < h)
                    {
                        h = k;
                    }
                    if (k > t)
                    {
                        t = k;
                    }
                }
            }
            Console.WriteLine("Numero Menor es: " + h);
            Console.WriteLine("Numero Mayor es: " + t);
            Console.ReadKey();
        }
    }
}