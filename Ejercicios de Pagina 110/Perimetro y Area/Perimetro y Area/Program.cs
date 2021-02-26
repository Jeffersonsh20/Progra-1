using System;

namespace PERIMETRO_Y_AREA
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int a;
            int k;
            int g;
            int e;
            Console.Write("Digite la base: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite la Altura: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine();
            Console.WriteLine("1). Perimetro ");
            Console.WriteLine("2). Area ");
            Console.Write("Seleccione una Opcion: ");
            g = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (g)
            {
                case 1:
                    e = (a * 2) + (k * 2);
                    Console.WriteLine("El perimetro de uun rectangulo es" + e);
                    break;
                case 2:
                    j = a * k;
                    Console.WriteLine("El area de un rectangulo es " + j);
                    break;
                default:
                    Console.WriteLine("Numero no valido: ");
                    break;
            }
            Console.ReadKey();
        }
    }
}