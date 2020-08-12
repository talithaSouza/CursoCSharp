using System;

namespace Q01 {
	class Program {
		static void Main (string[] args) {
			int x;

			do{
				Console.WriteLine("Digite o valor do intervalo(1 a 1000): ");
				x = int.Parse(Console.ReadLine());
			}while(x < 1 || x > 1000);

			for(int i = 1; i <= x; i++){
				if(i % 2 != 0)
					Console.WriteLine(i);
			}
		}
	}
}