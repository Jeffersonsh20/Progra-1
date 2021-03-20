using System;
using System.Threading;

namespace Tarea5_Ejercicio_2
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int FF = 22;
            int CF = 77;
            int FI = 2;
            int CI = 2;
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)
            {
                for (F = CI; F <= CF; F++)
                {
                    Console.SetCursorPosition(F, FF); Console.Write("?");
                    Console.SetCursorPosition(F, FI); Console.Write("?");
                }
                for (C = CI; C <= FF; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("X");
                    Console.SetCursorPosition(CF, C); Console.Write("X");
                }
                FI = FI + 1;
                FF = FF - 1;
                CI = CI + 1;
                CF = CF - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int tam = 1; tam < 9; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }

        }

    }
}
