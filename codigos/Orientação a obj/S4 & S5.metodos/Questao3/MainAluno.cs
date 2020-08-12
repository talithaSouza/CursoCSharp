using System;
using System.Globalization;

namespace Questao3 {
  class Program {
    static void Main (string[] args) {
      Aluno A = new Aluno ();

      Console.Write("Digite o nome do aluno: ");
      A.Nome = Console.ReadLine();
      Console.WriteLine ("Digite as notas do aluno:");
      Console.Write ("Nota 1: ");
      A.N1 = Double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
      Console.Write ("Nota 2: ");
      A.N2 = Double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
      Console.Write ("Nota 3: ");
      A.N3 = Double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

      A.Situacao();
    }
  }
}