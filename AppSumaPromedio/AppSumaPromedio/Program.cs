using System;

namespace AppSumaPromedio
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1, num2, num3, num4, suma, promedio;
			Console.WriteLine ("Programa que Calcula Suma y Promedio");
			Console.WriteLine ("Digite Numero 1:");
			num1 = double.Parse (Console.ReadLine());
			Console.WriteLine ("Digite Numero 2:");
			num2 = double.Parse (Console.ReadLine());
			Console.WriteLine ("Digite Numero 3:");
			num3 = double.Parse (Console.ReadLine());
			Console.WriteLine ("Digite Numero 4:");
			num4 = double.Parse (Console.ReadLine());

			suma = num1 + num2 + num3 + num4;
			promedio = suma / 4;
			Console.WriteLine ("La suma es: " + suma + " El promedio es: " + promedio);
			Console.ReadKey ();


		}
	}
}
