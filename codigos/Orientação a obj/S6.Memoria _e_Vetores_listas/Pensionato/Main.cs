using System;

namespace Pensionato {
  class Program {
    static void Main (string[] args) {
      int n;
      Quarto[] quartos = new Quarto[10];

      Console.Write("Digite a quantidade de quartos que deseja alugar: ");
      n = int.Parse(Console.ReadLine());
      
      for(int i = 0; i < n; i++){
        Console.WriteLine($"Aluguel #{i+1}");
        Console.Write("Digite o nome do estudante: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o E-mail: ");
        string email = Console.ReadLine();
        Console.Write("Qual o numero do Quarto? ");
        int num = int.Parse(Console.ReadLine());

        quartos[num] = new Quarto(nome, email);
      }

      Console.WriteLine("\nRelação de quartos ocupados:");
      for(int i = 0; i < 10; i++){
        if(quartos[i] != null)
          Console.WriteLine($"{i} {quartos[i]}");
      }
    }
  }
}