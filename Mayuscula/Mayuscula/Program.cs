using System;

namespace Mayus
{
    class Mayus
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Escriba cualquier letra: \n");
            letra = Console.ReadLine();


            if (letra == "A" || letra == "B" || letra == "C" || letra == "D" || letra == "E" ||
                letra == "F" || letra == "G" || letra == "H" || letra == "I" || letra == "J" ||
                letra == "K" || letra == "L" || letra == "M" || letra == "N" || letra == "Ñ" ||
                letra == "O" || letra == "P" || letra == "Q" || letra == "R" || letra == "S" ||
                letra == "T" || letra == "U" || letra == "V" || letra == "W" || letra == "X" ||
                letra == "Y" || letra == "Z") { Console.WriteLine(" SI ES MAYUSCULA "); }
            else
            {
                Console.WriteLine("NO ES MAYUSCULA :");
                Console.WriteLine();
                Console.Write("Presione una tecla para terminar . . . ");
                Console.ReadKey();
            }
        }
    }