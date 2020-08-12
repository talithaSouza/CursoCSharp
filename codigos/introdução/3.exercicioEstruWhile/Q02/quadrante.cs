using System;

namespace Q02 {
	class Program {
		static void Main (string[] args) {
			double x, y;

			Console.Write ("Digite o valor da coordeanda X: ");
			x = double.Parse (Console.ReadLine ());
			Console.Write ("Digite o valor da coordeanda Y: ");
			y = double.Parse (Console.ReadLine ());

			while (x != 0.0 && y != 0.0) {
				if (x > 0.0 && y > 0.0)
					Console.WriteLine ("Primeiro");
				else if (x > 0.0 && y < 0.0)
					Console.WriteLine ("Quarto");
				else if (x < 0.0 && y > 0.0)
					Console.WriteLine ("Segundo");
				else
					Console.WriteLine ("Terceiro");

				x = double.Parse (Console.ReadLine ());
				y = double.Parse (Console.ReadLine ());
			}
		}
	}
}