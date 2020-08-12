using System;

namespace Q01 {
	class Program {
		static void Main (string[] args) {
			int senha;

			Console.Write("Digite a senha numérica: ");	
			senha = int.Parse(Console.ReadLine());

			while(senha != 2002){
				Console.WriteLine("Senha Invalida");
				senha = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Acesso permitido");
		}
	}
}