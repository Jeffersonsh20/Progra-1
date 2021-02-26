using System;

namespace SERIE_FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int k;
            int j;
            int t;
            int i;
            Console.Write("Cuantos numeros va imprimir: ");
            total = int.Parse(Console.ReadLine());
            k = 1;
            j = 1;
            Console.Write(k + " " + j);
            for (i = 3; i <= total; i++)
            {
                t = k + j;
                Console.Write(" " + t + " ");
                k = j;
                j = t;
            }
            Console.ReadKey();
        }
    }
}