using System.Globalization;
using System;

namespace Curso {
	class Program {
		static void Main (string[] args) {

			Produto p =  new Produto();

			Console.WriteLine ("Entre com os dados do produto:");
			Console.Write("Nome: ");
			p.Nome = Console.ReadLine();
			Console.Write("Preço: ");
		  p.Preco =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Dados de um produto: " + p);

			
			//constutor com dois argumentos
			/*Produto p = new Produto(nome, preco);
      Console.WriteLine();
			Console.WriteLine("Dados do produto: " + p);
			*/

			/*FORMA ALTERNATIVA
			Produto p = new Produto{
				_nome = nome,
				Preco = preco,
				_qtd = 3
			};
			Console.WriteLine("Dados de um produto: " + p);
			*/

			
      Console.WriteLine();
      Console.Write("Digite a qtd a ser adicionada no estoque: ");
      int qte = int.Parse(Console.ReadLine());
      p.AdicionarProdutos(qte);
			
      Console.WriteLine();
      Console.WriteLine("Dados de um produto: " + p);

      Console.WriteLine();
      Console.Write("Digite a qtd a ser removida no estoque: ");
      qte = int.Parse(Console.ReadLine());
      p.RemoverProdutos(qte);

      Console.WriteLine();
      Console.WriteLine("Dados de um produto: " + p);
			

		}
	}
}