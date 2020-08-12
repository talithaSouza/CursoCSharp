using System;
using System.Globalization;

namespace ContaBancaria {

  class Conta{
    public string Nome{get; set; }
    public int Numero { get; private set; }
    public double Saldo{get; private set; }

    public Conta(){

    }

    public Conta(int numero, string nome){
      Nome = nome;
      Numero = numero;
      Saldo = 0.00;
    }

    public Conta(int numero, string nome, double valor): this(numero, nome){
      Deposito(valor);
    }

    public void Deposito(double valor){
      Saldo += valor;
    }

    public void Saque(double valor){
      Saldo -= (valor + 5);
    }

    public override string ToString(){
      return "Conta: " + Numero + ", "
      +"Titular: " + Nome + ", "
      + "Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }



  }
}