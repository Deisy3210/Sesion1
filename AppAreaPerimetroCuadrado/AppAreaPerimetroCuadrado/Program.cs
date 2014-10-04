using System;

namespace AppAreaPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro;
			Console.WriteLine ("Programa que Calcula Area y Perimetro de un Cuadrado");
			Console.WriteLine ("Digite Lado:");
			lado = float.Parse (Console.ReadLine ());
			area = lado * lado;
			Console.WriteLine ("El area del cuadrado es:" + area);
			perimetro = 4 * lado;
			Console.WriteLine ("El perimetro es:" + perimetro);
			Console.ReadKey ();

		}
	}
}
