using System;

namespace Q06 {
	class Program {
		static void Main (string[] args) {
			int n;

			Console.Write("Digite o valor de n: ");
			n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= n; i++){
				if(n % i == 0)
					Console.WriteLine(i);
			}
		}
	}
}