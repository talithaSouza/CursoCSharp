using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista {
  class Program {
    static void Main (string[] args) {
      List<Funcionario> listaFunci = new List<Funcionario> ();
      Funcionario funci;

      Console.Write ("Digite a quantidade de cadastros: ");
      int n = int.Parse (Console.ReadLine ());

      for (int i = 0; i < n; i++) {
        Console.Write ("Digite o id: ");
        int id = int.Parse (Console.ReadLine ());

        //verifica se o id digitado já existe        
        while (listaFunci.FindIndex (x => x.Id == id) != -1) {
          Console.WriteLine ("Id já existente");
          Console.Write ("Digite um outro Id: ");
          id = int.Parse (Console.ReadLine ());
        }

        Console.Write ("Digite o nome: ");
        string nome = Console.ReadLine ();
        Console.Write ("Digite o salario: R$ ");
        double sal = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

        listaFunci.Add (funci = new Funcionario (id, nome, sal));

      }

      Console.WriteLine ();
      Console.Write ("Digite o id fo funcinário que deseja aumentar o salario: ");
      int ide = int.Parse (Console.ReadLine ());

      //teste se existe o id digitado
      Funcionario fun = listaFunci.Find(x => x.Id == ide);
      if (fun == null)
        Console.WriteLine ("Id não existente");
      else {
        Console.Write ("Digite a porcentagem de aumento: ");
        double porc = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
        fun.AumentaSalario(porc);

      }
      foreach (Funcionario f in listaFunci) {
        Console.WriteLine(f);
      }

    }

  }
}