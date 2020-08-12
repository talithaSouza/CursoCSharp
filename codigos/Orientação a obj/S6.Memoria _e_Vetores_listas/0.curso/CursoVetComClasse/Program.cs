using System.Globalization;
using System;

namespace CursoVetComClasse {
  class Program {
    static void Main (string[] args) {
      
      int n = int.Parse(Console.ReadLine());
      Produto[] prod = new Produto[n];

      for(int i = 0; i < n; i++){
        string nome = Console.ReadLine();
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        prod[i] = new Produto{Nome = nome, Preco = preco};
      }

      double soma = 0;
      for(int i = 0; i < n; i++){
        soma += prod[i].Preco;
      }
      double media = soma/n;

      Console.WriteLine();
      Console.WriteLine("Preco medio igual a R$ " + media.ToString("F2", CultureInfo.InvariantCulture));

    }
  }
}