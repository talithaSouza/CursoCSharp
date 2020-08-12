using System;
using System.Globalization;

namespace Q05 {
	class Program {
		static void Main (string[] args) {
			int cod1, cod2, qtd1, qtd2;
			double preco1, preco2, total;

			Console.Write("Digite o código do produto 1: ");
			cod1 = int.Parse(Console.ReadLine());
			Console.Write("Digite a quantidade: ");
			qtd1 = int.Parse(Console.ReadLine());
			Console.Write("Digite o valor unitário do produto: ");
			preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("\n");

			Console.Write("Digite o código do produto 2: ");
			cod2 = int.Parse(Console.ReadLine());
			Console.Write("Digite a quantidade: ");
			qtd2 = int.Parse(Console.ReadLine());
			Console.Write("Digite o valor unitário do produto: ");
			preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			total = (qtd1 * preco1) + (qtd2 * preco2);
			Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


		}
	}
}