using System;

namespace Dias_de_un_MES
{
    class Dias_de_un_MES
    {
        static void Main(string[] args)
        {

            int anno, dia, dias, dias_que_faltan, mes;
            Console.Write("Ingrese el valor de año: ");
            anno = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de mes: ");
            mes = int.Parse(Console.ReadLine());
            dias = 0;
            if (mes == 2 && (((anno % 4 == 0) && (anno % 100 != 0)) || anno % 400 == 0))
                dias = 29;
            if (mes == 2 && (((anno % 4 != 0) || (anno % 100 == 0)) && anno % 400 != 0))
                dias = 28;
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                dias = 31;
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                dias = 30;
            dias_que_faltan = dias - dia;
            Console.WriteLine("Valor de dias: " + dias);
            Console.WriteLine("Valor de dias que faltan: " + dias_que_faltan);
            Console.WriteLine();
            Console.Write("Presione una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}