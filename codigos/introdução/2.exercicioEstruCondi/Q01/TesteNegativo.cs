using System;

namespace Q01 {
	class Program {
		static void Main (string[] args) {

			Console.Write("Digite um numero: ");
      int n = int.Parse(Console.ReadLine());

			if(n >= 0)
				Console.WriteLine("Positivo");
			else
				Console.WriteLine("Negativo");

		}
	}
}