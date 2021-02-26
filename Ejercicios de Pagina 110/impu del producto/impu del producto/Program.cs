using System;

namespace PORCENTAJE
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opc;
            decimal iva = 12;
            decimal e;
            decimal pag;
            Console.WriteLine("Que producto va a pagar");
            Console.WriteLine("1). Medicina");
            Console.WriteLine("2). Otro");
            Console.Write("Seleccione una opcion: ");
            opc = byte.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Write("Escriba su total a pagar: ");
                    e = decimal.Parse(Console.ReadLine());
                    pag = e;
                    Console.Write("Su total de pago es " + pag); break;
                case 2:
                    Console.Write("Escriba su total a pagar: ");
                    e = decimal.Parse(Console.ReadLine());
                    iva = ((e * 12) / 100);
                    pag = iva + e;
                    Console.Write("Su total de pago es " + pag); break;
                default: Console.Write("Numero no valido"); break;
            }
            Console.ReadKey();
        }
    }

}
