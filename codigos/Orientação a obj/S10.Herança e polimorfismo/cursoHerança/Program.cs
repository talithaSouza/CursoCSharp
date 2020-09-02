using System;
using cursoHerança.Entites;

namespace cursoHerança {
  class Program {
    static void Main (string[] args) {
      BusinessAccount bc = new BusinessAccount(01, "Talitha", 100, 100);
      Console.WriteLine (bc.Balace);
    }
  }
}