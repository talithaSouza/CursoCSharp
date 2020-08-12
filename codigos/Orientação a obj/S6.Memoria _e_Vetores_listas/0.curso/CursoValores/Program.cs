using System;

namespace Curso {
	class Program {
		static void Main (string[] args) {
			
			double ? x = null;
			double ? y = 10.0;

			Console.WriteLine(x.GetValueOrDefault());
			Console.WriteLine(y.GetValueOrDefault());

			Console.WriteLine(x.HasValue); // testa se tem valor
			Console.WriteLine(y.HasValue);

			if(x.HasValue)
				Console.WriteLine(x.Value);
			else
				Console.WriteLine("X é nulo");
				
			Console.WriteLine(y.Value);
		}
	}
}
