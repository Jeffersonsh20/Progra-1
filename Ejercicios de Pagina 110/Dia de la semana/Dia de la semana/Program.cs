using System;

namespace DIAS_DE_LA_SEMANA
{
    class Program
    {
        static void Main(string[] args)
        {
            String j;
            int k;
            Console.WriteLine("1. Es Lunes");
            Console.WriteLine("2. Es Martes");
            Console.WriteLine("3. Es Miercoles");
            Console.WriteLine("4. Es Jueves");
            Console.WriteLine("5. Es Viernes");
            Console.WriteLine("6. Es Sabado");
            Console.WriteLine("7. Es Domingo");
            Console.Write("Ingrese un Numero de dia: ");
            j = Console.ReadLine();
            k = int.Parse(j);
            Console.WriteLine();
            switch (k)
            {
                case 1: Console.WriteLine("Dia Lunes"); break;
                case 2: Console.WriteLine("Dia Martes"); break;
                case 3: Console.WriteLine("Dia Miercoles"); break;
                case 4: Console.WriteLine("Dia Jueves"); break;
                case 5: Console.WriteLine("Dia Viernes"); break;
                case 6: Console.WriteLine("Dia Sabado"); break;
                case 7: Console.WriteLine("Dia Domingo"); break;
                default: Console.WriteLine("Numero no valido"); break;
            }
            Console.ReadKey();
        }
    }
}