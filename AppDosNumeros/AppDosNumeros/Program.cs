using System;

namespace AppDosNumeros
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1, num2, suma, diferencia, producto, division;
			Console.WriteLine ("Programa mayor de dos numeros");
			Console.WriteLine ("Lea numero 1: ");
			num1=double.Parse(Console.ReadLine());
			Console.WriteLine ("Lea numero 2: ");
			num2=double.Parse(Console.ReadLine());
			if (num1 > num2) {
				suma = num1 + num2;
				diferencia = num1 - num2;
				Console.WriteLine ("La suma es: " + suma);
				Console.WriteLine ("La diferencia es: " + diferencia);
			} 
			else
			{
				producto = num1 * num2;
				division = num2 / num1;
				Console.WriteLine ("La producto es: " + producto);
				Console.WriteLine ("La division es: " + division);
			}

			Console.ReadKey ();
		}
	}
}
