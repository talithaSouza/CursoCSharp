using System;

namespace CursoModificadores {
  class Program {
    static void Main (string[] args) {

      string[] vetor = new string[] { "Maria", "Alex", "Bob" };

      foreach (string nome in vetor) {
        Console.WriteLine(nome);
      }

      /*EXEMPLO DE COMO USAR  OUT
        Calculator.Triple (a, out triplo);
        Console.WriteLine (triplo);
      */
    }
    //FUNÇÃO COM  MAIS DE UM PARAMETRO
    /*static int Sum (params int[] numbers) {
      int sum = 0;
      for (int i = 0; i < numbers.Length; i++) {
        sum += numbers[i];
      }
      return sum;
    }
    */
  }
}