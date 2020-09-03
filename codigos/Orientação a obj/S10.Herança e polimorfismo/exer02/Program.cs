using System;
using System.Globalization;
using System.Collections.Generic;
using exer02.Entites;

namespace exer02 {
  class Program {
    static void Main (string[] args) {
      List <Produto> lista = new List<Produto>();

      Console.Write("Entre com o numero de produtos: ");
      int n = int.Parse(Console.ReadLine());

      for(int i = 0; i < n; i++){
        Console.WriteLine($"Produto #{i+1}: ");
        Console.Write("O produto eh Comum, Importado ou Usado? (c/i/u) ");
        char resp = char.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preco: R$ ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //TESTE DE ESCOLHA
        if(resp == 'c'){
          lista.Add(new Produto(nome, preco));
        }
        if(resp == 'i'){
          Console.Write("Taxa: R$ ");
          double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          lista.Add(new ProdutoImportado(nome,preco,taxa));
        }
        if(resp == 'u'){
          Console.Write("Data de fabricação: (dd/mm/yyyy) ");
          DateTime data = DateTime.Parse(Console.ReadLine());
          lista.Add(new ProdutoUsado(nome, preco, data));
        }
        Console.Clear();
      }
      
      foreach(Produto p in lista){
        Console.WriteLine(p.Etiqueta());
      }

    }
  }
}