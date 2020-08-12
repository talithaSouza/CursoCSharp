using System.Runtime.Intrinsics.X86;
using System.Globalization;
using System;

namespace Questao2 {
  class Program {
    static void Main (string[] args) {
      Funcionario func = new Funcionario();

      Console.WriteLine ("Digite os dados do funcionario:");
      Console.Write("Nome: ");
      func.Nome = Console.ReadLine();
      Console.Write("Salario Bruto: R$ ");
      func.SalBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Imposto: R$ ");
      func.Imposto =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine();
      Console.WriteLine("Dados do Funcionario: " + func);

      Console.WriteLine();
      Console.Write("Digite a porcentagem de aumento do salario: ");
      float porc = float.Parse(Console.ReadLine());
      func.AumentaSalario(porc);

      Console.WriteLine();
      Console.WriteLine("Dados atualizados: " + func);

    }
  }
}