using System;

namespace PAR_O_IMPAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int numer;
            Console.Write("Ingrese un Numero: ");
            numer = int.Parse(Console.ReadLine());
            if (numer % 2 != 0)
            {
                Console.WriteLine("El numero es impar");
            }
            else
            {
                Console.WriteLine("El numero es par");
            }
            Console.ReadKey();
        }
    }
}