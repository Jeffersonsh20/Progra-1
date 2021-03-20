using System;

namespace ejercicio_3
{
    class Program
    {
        public static string generaletra(int min, int max)

        {
            Random ran = new Random();
            int NUM = Convert.ToInt32(ran.Next(100));
            string letrarespuesta = "";
            if (((NUM > 0) & (NUM < 256)))
            {
                letrarespuesta = Convert.ToString((char)NUM);
            }
            return letrarespuesta;
        }
        static void Main(string[] args)
        {
            byte CAN, K;
            string LINEA;
            Console.Write("Cuantos numeros?");
            LINEA = Console.ReadLine();
            CAN = byte.Parse(LINEA);

            string letra = "";

            for (K = 1; K <= CAN; K++)
            {
                letra = generaletra(99, 120);
                Console.WriteLine($"letra generada={letra}");
            }
        }
    }
}
