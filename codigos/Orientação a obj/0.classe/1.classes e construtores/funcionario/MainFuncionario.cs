using System;
using System.Globalization;

namespace funcionario {
	class Program {
		static void Main (string[] args) {
			Funcionario fun1, fun2;
			fun1 = new Funcionario();
			fun2 = new Funcionario();

			Console.Write("Digite o nome do primeiro funcionário: ");
			fun1.nome = Console.ReadLine();
			Console.Write("Digite o salario do funcinário  {0}: ", fun1.nome);
			fun1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine();

			Console.Write("Digite o nome do segundo funcionário: ");
			fun2.nome = Console.ReadLine();
			Console.Write("Digite o salario do funcinário  {0}: ", fun2.nome);
			fun2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double salMedio = (fun1.salario + fun2.salario)/2.0;
			Console.WriteLine("\nSalario médio: " + salMedio.ToString("F2", CultureInfo.InvariantCulture));

		}
	}
}