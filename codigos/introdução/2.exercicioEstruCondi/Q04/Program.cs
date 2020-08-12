using System;

namespace Q04 {
	class Program {
		static void Main (string[] args) {
			int hrInicial, hrFinal, hrJogo;

			Console.Write ("Digite a hora inicial: ");
			hrInicial = int.Parse (Console.ReadLine ());
			Console.Write ("Digite a hora final: ");
			hrFinal = int.Parse (Console.ReadLine ());
			//intervalo de 0h -- 12h

			//hora inical menor que a final
			if (hrInicial < hrFinal)
				hrJogo = hrFinal - hrInicial;
			//hora inicial maior que a final
			else if (hrInicial > hrFinal)
				hrJogo = (24 - hrInicial) + hrFinal;
			else
				hrJogo = 24;

			Console.WriteLine ($"O JOGO DUROU {hrJogo} HORA(S)");

		}
	}
}