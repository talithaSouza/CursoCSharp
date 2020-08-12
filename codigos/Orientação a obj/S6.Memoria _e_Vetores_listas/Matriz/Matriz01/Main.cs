using System;

namespace Matriz {
  class Program {
    static void Main (string[] args) {
      int[, ] matriz;
      int n, qtdNegativos = 0;

      Console.Write ("Digite o tamanho da matriz quadrada: ");
      n = int.Parse (Console.ReadLine ());
      matriz = new int[n, n];

      for (int i = 0; i < n; i++) {
        string[] linha = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++) {
          matriz[i, j] = int.Parse(linha[j]);
        }
      }

      Console.WriteLine ("\n matriz:");
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          Console.Write (matriz[i, j] + "  ");
        }
        Console.WriteLine();
      }

      Console.WriteLine ("\n diagonal principal:");
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          if(matriz[i,j] < 0)
            qtdNegativos++;
          if(i == j)
            Console.Write (matriz[i, j]);
          else
            Console.Write("  ");
        }
        Console.WriteLine();
      }
      Console.WriteLine("Quantidade de numeros negativos: " + qtdNegativos);

      
    }
  }
}