using System;

namespace NUMERO_ELEVADO
{
    class Program
    {
        static void Main(string[] args)
        {
            double nume;
            double potenc;
            double result = 1;
            int k;
            Console.Write("Escriba una potencia: ");
            potenc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriba un numero: ");
            nume = Convert.ToDouble(Console.ReadLine());
            for (k = 1; k <= potenc; k++)
            {
                result = (result * nume);
            }
            Console.WriteLine("Su resultado es: " + result);
            Console.ReadKey();
        }
    }
}