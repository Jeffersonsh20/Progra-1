using System;

namespace Salario
{
    class Salario
    {
        static void Main(string[] args)
    {
        double horas_trabajadas, pago_por_hora, salario_del_trabajador;
        Console.Write("Ingrese el valor de horas trabajadas: ");
        horas_trabajadas = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de pago por hora: ");
        pago_por_hora = double.Parse(Console.ReadLine());
        salario_del_trabajador = horas_trabajadas * pago_por_hora;
            if (horas_trabajadas > 40)
                salario_del_trabajador = salario_del_trabajador + (horas_trabajadas - 40) * pago_por_hora ;
        Console.WriteLine("Valor de salario del trabajador: " + salario_del_trabajador);
        Console.WriteLine();
        Console.Write("Presione una tecla para terminar . . . ");
        Console.ReadKey();
    }
}
}