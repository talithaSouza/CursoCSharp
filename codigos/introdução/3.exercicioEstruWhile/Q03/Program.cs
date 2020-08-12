using System;

namespace Q03 {
	class Program {
		static void Main (string[] args) {
			int cod, alcool1, gaso2, disel3;
			alcool1 = gaso2 = disel3 = 0;

			do{
				Console.WriteLine ("Digite o codigo do seu combustivel");
				cod = int.Parse(Console.ReadLine());

				while(cod < 1 || cod 	> 3 && cod != 4){
					Console.WriteLine("Codigo invalido!! Digite novamente o codigo: ");
					cod = int.Parse(Console.ReadLine());
				}

				if (cod == 1)
					alcool1++;
				else if(cod == 2)
					gaso2++;
				else if(cod == 3)
					disel3++;
			}while(cod != 4);



			Console.WriteLine("\nMUITO OBRIGADE!!");
			Console.WriteLine("Alcool:  " + alcool1);
			Console.WriteLine("Gasolina: "+  gaso2);
			Console.WriteLine("Disel: " + disel3);


				


			


		}
	}
}