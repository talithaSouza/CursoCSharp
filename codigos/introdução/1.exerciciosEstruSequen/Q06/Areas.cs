using System.Globalization;
using System;

namespace Q06 {
	class Areas {
		static void Main (string[] args) {
			double A, B, C;
			double aTrian, aCir, aTrap, aQuad, aRetan;

			Console.Write("Digite o valor de A: ");
			A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o valor de B: ");
			B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Digite o valor de C: ");
			C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			aTrian = (A * C) / 2.0;
			aCir   = 3.14159 * (C * C);
			aTrap  = ((A + B) * C) / 2;
			aQuad  = B * B;
			aRetan = A * B;
			
			Console.WriteLine();
			Console.WriteLine("TRIANGULO: " + aTrian.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("Circulo: " + aCir.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("TRAPEZIO : " + aTrap.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("QUADRADO: " + aQuad.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("RETANGULO: " + aRetan.ToString("F3", CultureInfo.InvariantCulture));

		}
	}
}