using System.Globalization;
using System;

namespace Q03 {
	class Program {
		static void Main (string[] args) {
			int n;
			double media, nota1, nota2, nota3;

			do{
				Console.Write("Digite o numero de vezes que o programa irá repetir: ");
				n = int.Parse(Console.ReadLine());
			}while(n <= 0);

			for(int i = 0; i < n; i++){
				string[] nums = Console.ReadLine().Split(' ');
				nota1 =	double.Parse(nums[0], CultureInfo.InvariantCulture);
				nota2 = double.Parse(nums[1], CultureInfo.InvariantCulture);
				nota3 = double.Parse(nums[2], CultureInfo.InvariantCulture);

				media = (nota1 * 2.0 +  nota2 * 3.0 + nota3 * 5)/10.0;
				Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));


			}


		}
	}
}