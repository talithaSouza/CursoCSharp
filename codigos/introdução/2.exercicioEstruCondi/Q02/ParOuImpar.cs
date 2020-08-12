using System;

namespace Q02 {
	class Program {
		static void Main (string[] args) {
			int n;

			Console.Write("Digite um numero: ");
			n = int.Parse(Console.ReadLine());

			if(n % 2 == 0)
				Console.WriteLine("PAR");
			else
				Console.WriteLine("IMPAR");
			
		}
	}
}