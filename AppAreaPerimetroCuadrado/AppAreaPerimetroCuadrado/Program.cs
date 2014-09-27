using System;

namespace AppAreaPerimetroCuadrado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float lado, area, perimetro;
			Console.WriteLine ("Programa que calcula el area y perimetro de un cuadrado");
			Console.WriteLine ("Digite lado");
			lado = float.Parse (Console.ReadLine());
			area = lado * lado;
			Console.WriteLine ("El area de un cuadrado es: "+area);
			perimetro = lado * 4;
			Console.WriteLine ("El perimetro de un cuadrado es: "+perimetro);
			Console.ReadKey ();
		}
	}
}
