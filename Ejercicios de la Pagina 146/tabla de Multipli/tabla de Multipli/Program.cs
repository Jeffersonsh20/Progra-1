using System;

namespace _1._Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numer, k, resulta;
            string lin;
            Console.Write("Ingrese el número que desea saber la tabla de multiplicar: ");
            lin = Console.ReadLine();
            numer = int.Parse(lin);
            k = 1;
            while ((k <= 10))
            {
                resulta = numer * k;
                Console.WriteLine("{0} * {1} = {2}", numer, k, resulta);
                k = k + 1;
            }
            Console.ReadLine();
        }
    }
}