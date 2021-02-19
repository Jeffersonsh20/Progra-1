using System;

namespace Numeros_PRIMOS
{
	class Numeros_PRIMOS
	{
		static void Main(string[] args)
		{

			int i, numero;
			Console.Write("Ingrese un n\u00FAmero:");
			numero = int.Parse(Console.ReadLine());
			for (i = 2; i < numero && numero % i != 0; i++) ;
			if (i == numero)
				Console.WriteLine("\nW1 n\u00FAmero " + numero + " s\u00ED es primo.");
			else
				Console.WriteLine("\nW1 n\u00FAmero " + numero + " s\u00ED no es primo.");
			Console.WriteLine("\nPresione una tecla para terminar . . . ");
			Console.ReadKey();
		}
	}
}