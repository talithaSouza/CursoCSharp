using System.Globalization;
using System;

namespace Questao1 {
  class Program {
    static void Main (string[] args) {
      Retangulo R =  new Retangulo();
			
			Console.Write("Digite a Largura do Retangulo: ");
      R.Largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Digite a altura do Retangulo: ");
      R.Altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine();
      Console.WriteLine(R);
    }
  }
}