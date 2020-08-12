using System;

namespace CursoMatrizes {
	class Program {
		static void Main (string[] args) {
			double[,] matriz = new double[2,3];

			Console.WriteLine("Quantidade de elementos: " + matriz.Length); //num total de elementos
			Console.WriteLine("Qtd de linhas: " + matriz.Rank); //retorna a qtd de linhas da matriz
			Console.WriteLine("Qtd de elementos na 1° dimensão: " + matriz.GetLength(0)); //retorna o tamanho da dimensão especificada, sendo 0 a primeira(linhas)
			Console.WriteLine("Qtd de elementos na coluna: "+ matriz.GetLength(1)); //1 segunda dimensão, colunas
		}
	}
}