using System;

namespace Megaplaza
{
    class Megaplaza
    {
        static void Main(string[] args)
        {
            double descuento, precio_a_pagar, precio_normal;
            Console.Write("Ingrese el valor de precio normal: ");
            precio_normal = double.Parse(Console.ReadLine());
            descuento = precio_normal > 300 ? precio_normal * 0.2 : 0;
            precio_a_pagar = precio_normal - descuento;
            Console.WriteLine("Valor de descuento: " + descuento);
            Console.WriteLine("Valor de precio a pagar: " + precio_a_pagar);
            Console.WriteLine();
            Console.Write("Presione una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}