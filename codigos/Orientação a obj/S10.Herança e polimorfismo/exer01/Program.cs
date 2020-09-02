using System;
using System.Collections.Generic;
using System.Globalization;
using exer01.Entites;

namespace exer01 {
  class Program {
    static void Main (string[] args) {
      List<Funcionario> funcionarios = new List<Funcionario> ();

      Console.Write ("Entre com o numero de funcionarios: ");
      int n = int.Parse (Console.ReadLine ());

      for (int i = 0; i < n; i++) {
        char resp;
        Console.WriteLine ($"Funcionario {i+1}:");
        do {
          Console.Write ("Tercerizado ? (S/N): ");
          resp = char.Parse (Console.ReadLine ());
        } while (resp != 'S' && resp != 'N');

        Console.Write ("Nome: ");
        string nome = Console.ReadLine ();
        Console.Write ("Horas: ");
        int horas = int.Parse (Console.ReadLine ());
        Console.Write ("Valor por hora: ");
        double valorPorHora = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

        if (resp == 'N')
          funcionarios.Add (new Funcionario (nome, horas, valorPorHora));
        else {
          Console.Write ("Adicional: ");
          double adicional = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

          funcionarios.Add (new FuncionarioTercerizado (nome, horas, valorPorHora, adicional));
        }

        Console.Clear ();

      }

      Console.WriteLine ("PAGAMENTOS:");
      foreach (Funcionario f in funcionarios) {
        Console.WriteLine ($"{f.Nome} - R${f.Pagamento().ToString("F2",CultureInfo.InvariantCulture)}");
      }

    }
  }
}