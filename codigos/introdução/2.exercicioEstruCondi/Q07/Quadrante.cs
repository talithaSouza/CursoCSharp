using System;
using System.Globalization;

namespace Q07 {
	class Program {
		static void Main (string[] args) {
			float x, y;

			Console.Write ("Digite o valor de x: ");
			x = float.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
			Console.Write ("Digite o valor de y: ");
			y = float.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

			if (x == 0.0 && y == 0.0)
				Console.WriteLine("Origem");
			else if(x == 0.0)
				Console.WriteLine("Eixo Y");
			else if(y == 0.0)
				Console.WriteLine("Eixo X");
			else if(x > 0.0 && y > 0.0)
				Console.WriteLine("Q1");
			else if(x > 0.0 && y < 0.0)
				Console.WriteLine("Q4");
			else if(x < 0.0 && y > 0.0)
				Console.WriteLine("Q2");
			else
				Console.WriteLine("Q3");

		}
	}
}