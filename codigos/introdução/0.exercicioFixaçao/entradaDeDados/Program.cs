using System.Globalization;
using System;

namespace entradaDeDados {
	class Program {
		static void Main (string[] args) {
			Console.WriteLine("Entre com seu nome completo: ");
			string nomeCompleto = Console.ReadLine();
			Console.WriteLine("Quantos quartos tem na sua casa? ");
			int qtdQuartos = int.Parse(Console.ReadLine());
			Console.WriteLine("Entre com o preço de um produto");
			double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Digite seu ultimo nome, idade e altura (na mesma linha): ");
			string[] vet = Console.ReadLine().Split(' ');

			Console.WriteLine(nomeCompleto);
			Console.WriteLine(qtdQuartos);
			Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
			Console.Write($"{vet[0]}\n{vet[1]}\n{vet[2]}");
		}
	}
}