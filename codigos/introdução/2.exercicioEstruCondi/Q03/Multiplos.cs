using System;

namespace Q03 {
	class Program {
		static void Main (string[] args) {
			int A, B;

			Console.Write("Digite o primeiro valor inteiro: ");
			A = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero inteiro: ");
			B = int.Parse(Console.ReadLine());

			if( (A % B == 0) || (B % A == 0))
				Console.WriteLine("SÃO MULTIPLOS");
			else
				Console.WriteLine("NÃO SÃO MULTIPLOS");
		}
	}
}