using System.Globalization;
using System;

namespace Statico {
	class Program {
		static void Main (string[] args) {

      double valorDolar, dolarComprar;

			Console.Write("Qual a cotação atual do dollar? ");
      valorDolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Quantos dolares você deseja comprar? ");
      dolarComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Valor a ser pagos em reais: R$ " + ConversorDeMoedas.ConverterEmDolar(valorDolar,dolarComprar).ToString("F2",CultureInfo.InvariantCulture));
		}
	}
}