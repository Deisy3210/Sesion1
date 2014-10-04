using System;

namespace AppSumaDosNumero
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//declaracion de variables
			int numero1, numero2, suma;
			string Linea;
			Console.WriteLine ("Programa Calcula la Suma de 2 Numeros");
			Console.WriteLine ("Digite Numero 1:");
			Linea = Console.ReadLine ();
			numero1 = int.Parse (Linea);
			Console.WriteLine ("Digite Numero 2:");
			Linea = Console.ReadLine ();
			numero2 = int.Parse (Linea);
			suma = numero1 + numero2;
			Console.WriteLine ("El resultado de la suma es:" + suma);
			Console.ReadKey ();
		}
	}
}


