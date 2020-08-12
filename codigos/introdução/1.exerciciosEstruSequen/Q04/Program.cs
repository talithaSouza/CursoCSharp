using System.Globalization;
using System;

namespace Q04 {
	class Program {
		static void Main (string[] args) {
			int num, horas;
			double salHoras, salario;

			Console.Write("Digite seu numero de funcionário: ");
			num = int.Parse(Console.ReadLine());
			Console.Write("Digite a sua quantidade de horas trabalhadas: ");
			horas = int.Parse(Console.ReadLine());
			Console.Write("Digite o valor que você ganha por hora trabalhada: ");
			salHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			salario = salHoras * horas;
			Console.WriteLine($"Numero do funcionário: {num}");
			Console.WriteLine("Salário = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
			
		}
	}
}