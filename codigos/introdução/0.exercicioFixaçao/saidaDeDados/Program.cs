using System.Globalization;
using System;

namespace SaidaDeDados {
	class Program {
        private const double V = 53.23467;

        static void Main (string[] args) {
			string produto1 = "Computador";
			string produto2 = "Mesa de escritório";
			byte idade = 30;
			int codigo = 290;
			char genero = 'm';
			double preco1 = 2100.0;
			double preco2 = 650.50;
			double medida = 53.234567;

			Console.Write("Produtos:\n");
			Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
			Console.WriteLine($"{produto2} cujo preço é R${preco2}\n");
			Console.WriteLine($"Registro: {idade} ano de idade, código {codigo} e gênero {genero}\n");
			Console.WriteLine($"Medida com oito casas de oito casas decimais {medida:F8}");
			Console.WriteLine($"Arredondado (três casa decimais): {medida:F3}");
			Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

		}
	}
}