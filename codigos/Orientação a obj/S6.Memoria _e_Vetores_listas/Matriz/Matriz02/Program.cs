using System;

namespace Matriz02 {
  class Program {
    static void Main (string[] args) {
      int n, m;
      int[, ] matriz;

      Console.Write ("Digite a quantidade de linhas: ");
      n = int.Parse (Console.ReadLine ());
      Console.Write ("Digite a quantidade de colunas: ");
      m = int.Parse (Console.ReadLine ());
      matriz = new int[n, m];

      Console.Clear ();
      Console.WriteLine ("Preencher a matriz:");
      for (int i = 0; i < n; i++) {
        string[] linha = Console.ReadLine().Split(' ');
        for (int j = 0; j < m; j++) {
          if (j > linha.Length - 1) //se a quantidade de colunas for maior do que a quantidade preenchida
            matriz[i, j] = 0;
          else
            matriz[i, j] = int.Parse (linha[j]);
        }

      }

      Console.WriteLine ("\nMatriz:");
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
          Console.Write (matriz[i, j] + " ");
        }
        Console.WriteLine ();
      }

      Console.Write("\nDigite o numero que deseja procurar:  ");
      int x = int.Parse(Console.ReadLine());
      for (int i = 0; i < n; i++) {
        for(int j = 0; j <  m; j++){
          if(matriz[i,j] == x){
            Console.WriteLine($"Position[{i},{j}]");
            if(j != 0) //esqueda
              Console.WriteLine("Left: "+ matriz[i,j-1]);
            if(j != m-1) //direita
              Console.WriteLine("Right: "+ matriz[i,j+1]);
            if(i != 0)//cima
              Console.WriteLine("Up: "+ matriz[i-1,j]);
            if(i != n-1)//baixo
              Console.WriteLine("Down: "+ matriz[i+1,j]);
          }
        }
      }
    }
  }
}