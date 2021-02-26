using System;

namespace RADIANES_A_GRADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double numer;   
            double obtr;
            double pi = 3.1416;
            Console.Write("Que desea Convertir: ");
            Console.WriteLine("\n1). Grados");
            Console.WriteLine("2). Radianes");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Escriba los Grados: ");
                    numer = double.Parse(Console.ReadLine());
                    obtr = numer * pi / 180;
                    Console.WriteLine("Su resultado es: " + obtr); break;
                case 2:
                    Console.Write("Escriba los Grados: ");
                    numer = double.Parse(Console.ReadLine());
                    obtr = 180 / pi * numer;
                    Console.WriteLine("Su resultado es: " + obtr); break;
                default: Console.Write("Numero no valido"); break;
            }
            Console.ReadKey();
        }
    }
}