using System;
using CursoOverride.Entites;

//OVERRIDE: NA CLASSE ACCOUNT TEM UMA  TAXA DE SAQUE, MAS PARA A CLASSE SAVINGSACCOUNT NÃO

namespace Upcastig__e__downcasting {
  class Program {
    static void Main (string[] args) {
     Account acc1 = new Account(1001, "Alex", 500.0);
     Account acc2 = new SavingsAccount(1002, "Aana", 500.0, 0.1);

     acc1.Withdraw(10.0);
     acc2.Withdraw(10);

     Console.WriteLine(acc1.Balace);
     Console.WriteLine(acc2.Balace);
    }
  }
}