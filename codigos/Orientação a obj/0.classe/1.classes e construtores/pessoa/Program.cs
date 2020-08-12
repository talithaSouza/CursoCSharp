using System;

namespace _0.classe {
	class Program {
		static void Main (string[] args) {
			Pessoa p1, p2;

			p1 = new Pessoa ();
			p2 = new Pessoa ();

			Console.Write ("Digite o nome da pessoa 1: ");
			p1.nome = Console.ReadLine();
			Console.Write ("Digite a idade da pessoa 1: ");
			p1.idade = int.Parse(Console.ReadLine());

			Console.Write ("Digite o nome da pessoa 2: ");
			p2.nome = Console.ReadLine();
			Console.Write ("Digite a idade da pessoa 2: ");
			p2.idade = int.Parse(Console.ReadLine());

			if(p1.idade > p2.idade)
				Console.WriteLine($"{p1.nome} eh mais velha(o)");
			else
				Console.WriteLine($"{p2.nome} eh mais velha(o)");
		}
	}
}