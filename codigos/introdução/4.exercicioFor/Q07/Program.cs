using System;

namespace Q07 {
	class Program {
		static void Main (string[] args) {
			int n;

			do{
				Console.WriteLine ("Digite o valor de n");
				n = int.Parse(Console.ReadLine());
			}while(n < 1);
			Console.WriteLine();

			for(int i = 1; i <= n; i++){
				Console.WriteLine("{0} {1} {2}", i, Math.Pow(i,2), Math.Pow(i,3));
			}
		}
	}
}