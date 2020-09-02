using System;
using Upcastig_e_downcasting.Entites;

namespace Upcastig__e__downcasting {
  class Program {
    static void Main (string[] args) {
      Account acc =  new  Account(1001,"Alex", 0.0);
      BusinessAccount  bacc  =  new BusinessAccount(1002, "Maria",  0.0, 500.0);

    //Upcasting - da subclasse pra superclasse
      //Perfeitamete possivel  pois  é uma relação  de é um
      //BusinessAccount  é  um  Account
      //Não é possivel usar as funções das outras classes na superclasse
      Account acc1  =  bacc;
      Account acc2  = new BusinessAccount(1003, "Bob", 0.0, 200);
      Account acc3  = new SavingsAccount(1004,"Ana", 0.0, 0.1);
   //-----------------------------------------------------------------

    //DOWNCASTING - Da  superclasse pra subclasse
      //precisa do  castinng explicito
      BusinessAccount acc4 =  acc2 as BusinessAccount; //SINTAXE ALTERNATICA PARA O CASTING

      //UMA OPERAÇÃO INSEGURA, PRECISA TESTAR ANTES DE CONVERTER
      if(acc3 is BusinessAccount){
        BusinessAccount acc5 = (BusinessAccount) acc3;
        acc5.Loan(200);
        Console.WriteLine("Loan!");
      }

      if(acc3 is SavingsAccount){
        SavingsAccount acc5  = acc3 as SavingsAccount;
        acc5.UpdateBalace();
        Console.WriteLine("Update");
      }
    //-----------------------------------------------------
    }
  }
}