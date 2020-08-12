using System;

namespace Q03 {
  class Diferenca {
    static void Main (string[] args) {
      int A, B, C, D, dif;

      Console.Write("Digite o valor de A: ");
      A = int.Parse(Console.ReadLine());
      Console.Write("Digite o valor de B: ");
      B = int.Parse(Console.ReadLine());
      Console.Write("Digite o valor de C: ");
      C = int.Parse(Console.ReadLine());
      Console.Write("Digite o valor de D: ");
      D = int.Parse(Console.ReadLine());

      dif = (A * B) - (C * D);
      Console.WriteLine("DIFERENÇA = " + dif);
    }
  }
}