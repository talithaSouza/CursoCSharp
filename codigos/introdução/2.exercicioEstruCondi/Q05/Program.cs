using System;
using System.Globalization;

namespace Q05 {
	class Program {
		static void Main (string[] args) {
			int cod, qtd;
			double total = 0;

			Console.Write("Digite o codigo do produto: ");
			cod = int.Parse (Console.ReadLine ());
			Console.Write ("Digite a quantidade: ");
			qtd = int.Parse (Console.ReadLine ());

			if (cod == 1)
				total = qtd * 4.0;
			else if (cod == 2)
				total = qtd * 4.5;
			else if (cod == 3)
				total = qtd * 5.0;
			else if (cod == 4)
				total = qtd * 2.0;
			else if (cod == 5)
				total = qtd * 1.5;

			Console.WriteLine ("Total: R$ " + total.ToString ("F2", CultureInfo.InvariantCulture));
		}
	}
}