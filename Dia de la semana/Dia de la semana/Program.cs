using System;

namespace Dia_de_la_semana
{
    class Dia_de_la_semana
    {
        static void Main(string[] args)
        {
            int dia_de_la_semana;
            Console.Write("Ingrese el valor de dia de la semana: ");
            dia_de_la_semana = int.Parse(Console.ReadLine());
            if (dia_de_la_semana == 1)
                Console.WriteLine("Lunes Dia de Trabajo");
            if (dia_de_la_semana == 2)
                Console.WriteLine("Martes Dia de Trabajo");
            if (dia_de_la_semana == 3)
                Console.WriteLine("Mi\u00E9rcoles Dia de Trabajo");
            if (dia_de_la_semana == 4)
                Console.WriteLine("Jueves Dia de Trabajo");
            if (dia_de_la_semana == 5)
                Console.WriteLine("Viernes Dia de Trabajo");
            if (dia_de_la_semana == 6)
                Console.WriteLine("S\u00E1bado Universidad");
            if (dia_de_la_semana == 7)
                Console.WriteLine("Domingo Feriado");
            if (dia_de_la_semana < 1 || dia_de_la_semana > 7)
                Console.WriteLine("D\u00EDa no v\u00E1lido");
            Console.WriteLine();
            Console.Write("Presione una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}