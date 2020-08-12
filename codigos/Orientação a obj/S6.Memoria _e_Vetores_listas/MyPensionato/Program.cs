using System;

namespace MyPensionato {
	class Program {
		static void Main (string[] args) {
			int n, op;
			bool continuar = true;

			Quarto[] quartos = new Quarto[10];

			while (continuar) {
				do {
					Console.Write ("Digite o numero da opção desejada: ");
					Console.WriteLine ();
					Console.WriteLine ("(1) Alugar  um quarto");
					Console.WriteLine ("(2)Ver relações de quartos alugados");
					Console.WriteLine ("(3) Encerrar aluguel");
					Console.WriteLine ("(0) Sair");
					op = int.Parse (Console.ReadLine ());

				} while (op < 0 || op > 3);
				Console.Clear ();
				switch (op) {
					case 1:
						Console.Write ("Digite a quantidade de quartos que deseja alugar: ");
						n = int.Parse (Console.ReadLine ());

						for (int i = 0; i < n; i++) {
							Console.WriteLine ($"Aluguel #{i+1}");
							Console.Write ("Digite o nome do estudante: ");
							string nome = Console.ReadLine ();
							Console.Write ("Digite o E-mail: ");
							string email = Console.ReadLine ();
							Console.Write ("Qual o numero do Quarto? ");
							int num = int.Parse (Console.ReadLine ());

							quartos[num] = new Quarto (nome, email);
						}
						Console.Clear();
						Console.WriteLine("Quartos  alugados com sucesso\n");
						break;

					case 2:
						Console.WriteLine ("\nRelação de quartos ocupados:");
						for (int i = 0; i < 10; i++) {
							if (quartos[i] != null)
								Console.WriteLine ($"{i} {quartos[i]}");
						}
						Console.WriteLine();
						break;

					case 3:
						Console.Write("Qual o numero do quarto que deseja encerrar o aluguel? ");
						int q =  int.Parse(Console.ReadLine());
						quartos[q] =  null;
						Console.Clear();
						Console.WriteLine("Aluguel encerrado  com sucesso\n");
						break;
					case 0:
						continuar = false;
						break;
				}

			}
			Console.Clear();
			Console.WriteLine("PROGRAMA ENCERRADO");
		}
	}
}