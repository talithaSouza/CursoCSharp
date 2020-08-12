using System.Globalization;
using System;

namespace Q02 {
	class AreaCirculo {
		static void Main (string[] args) {
			double area, raio, pi = 3.14159;

			Console.Write("Digite o raio da circunferência: ");
			raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			area = (double) (pi * (Math.Pow(raio,2)));
			Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

		}
	}
}