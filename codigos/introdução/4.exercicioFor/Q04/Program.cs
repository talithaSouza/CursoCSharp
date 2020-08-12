using System.Globalization;
using System;

namespace Q04 {
	class Program {
		static void Main (string[] args) {
			int n, p1, p2;

			Console.WriteLine ("Quantos pares de numero o programa irá ler? ");
			n =  int.Parse(Console.ReadLine());

			 for(int i = 0; i < (n * 2); i++){
				 string[] nums = Console.ReadLine().Split(' ');
				 p1 = int.Parse(nums[0]);
				 p2 = int.Parse(nums[1]);

				 if(p2 == 0)
				 	Console.WriteLine("Divisão impossivel");
					else{
						double res = (double) p1 / p2;
						Console.WriteLine(res.ToString("F1", CultureInfo.InvariantCulture));
					}
			 }
		}
	}
}