using System;

namespace FACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int k;
            int j;
            int h = 1;
            Console.Write("Coloque un numero: ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("El factorial es: " + h);
            }
            else
            {
                j = a;
                for (k = a; k > 1; k--)
                {
                    j = (j * (k - 1));
                }
                Console.WriteLine("El fatorial de " + a + " es: " + j);
            }
            Console.ReadKey();
        }
    }
}