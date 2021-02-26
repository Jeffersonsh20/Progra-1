using System;

namespace NUMEROS_PRIMOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantd = 0;
            int numer = 2;
            int k;
            Console.WriteLine("Numeros Primos entre uno y mil");
            while (numer <= 1000)
            {
                for (k = 1; k <= numer; k++)
                {
                    if (numer % k == 0)
                    {
                        cantd++;
                    }
                    if (cantd > 2)
                    {
                        break;
                    }
                }
                if (cantd == 2)
                {
                    Console.Write(numer + " ");
                }


                cantd = 0;
                numer++;
            }
            Console.ReadKey();
        }
    }
}