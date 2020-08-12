using System;

namespace Q02 {
  class Program {
    static void Main (string[] args) {
      int x, inter = 0, fora = 0;

      Console.Write("Digite o numero: ");
      x = int.Parse(Console.ReadLine());

      for(int i = 0; i < x; i++){
        Console.Write("Digite um numero: ");
        int n = int.Parse(Console.ReadLine());

        if(n >=  10 &&  n <= 20)
          inter++;
        else
          fora++;
        
      }

      Console.WriteLine($"{inter} in");
      Console.WriteLine($"{fora} out");

    }
  }
}