using System;
using System.Globalization;

namespace Q06 {
	class Program {
		static void Main (string[] args) {
			double n;

			Console.Write("Digite o numero: ");
			n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if(n >= 0 && n <= 25.0)
				Console.WriteLine("Intervalo [0, 25]");
			else if(n > 25.0 && n <= 50.0)
				Console.WriteLine("Intervalo (25,50]");
			else if(n > 50.0 && n <= 75.0)
				Console.WriteLine("Intervalo (50,75]");
			else if(n > 75.0 && n <= 100.0)
				Console.WriteLine("Intervalo (75,100]");
			else
				Console.WriteLine("Fora do intervalo");
		}
	}
}