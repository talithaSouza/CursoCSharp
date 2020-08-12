using System;

namespace Q05 {
	class Program {
		static void Main (string[] args) {
			int n;

			Console.Write("O numero do fatorial: ");
			n =  int.Parse(Console.ReadLine());
			
			if(n == 0)
				Console.WriteLine($"Fatorial de {0} = 1", n);
			else{
				for(int i = n; i >= 2; i--)
					n *= i - 1;

				Console.WriteLine($"Fatorial {n}");
			}
				
			
		}

	}
}