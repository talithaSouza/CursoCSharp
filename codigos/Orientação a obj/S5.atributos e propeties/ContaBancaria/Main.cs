using System;
using System.Globalization;

namespace ContaBancaria {
	class Program {
		static void Main (string[] args) {
			Conta conta1;
			string resp, nome;
			int num;
			double valor;

			Console.Write ("Entre o número da conta: ");
			num = int.Parse (Console.ReadLine ());
			Console.Write ("Entre com o nome do Titular: ");
			nome = Console.ReadLine ();
			do {
				Console.Write ("Haverá depósito, S/N ? ");
				resp = Console.ReadLine ();
			}while(resp != "S" && resp != "N");

			if(resp == "S"){
				Console.Write("Entre o valor de depósito inicial: R$ ");
				valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				conta1 = new Conta(num, nome, valor);
			}
			else{
				conta1 = new Conta(num, nome);
			}

			Console.WriteLine();
			Console.WriteLine("Dados da conta: \n" + conta1);

			Console.WriteLine();
			Console.Write("Entre um valor para depósito: R$ ");
			valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta1.Deposito(valor);
			Console.WriteLine();
			Console.WriteLine("Dados da conta: \n" + conta1);

			Console.WriteLine();
			Console.Write("Entre um valor para saque: R$ ");
			valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			conta1.Saque(valor);
			Console.WriteLine();
			Console.WriteLine("Dados da conta: \n" + conta1);


		}
	}
}