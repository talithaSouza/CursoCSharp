using System;

namespace Lista {
  class Funcionario {
    public int Id { get; private set; }
    public string Nome { get; set; }
    public double Salario { get; private set; }

    public Funcionario (int id, string nome, double salario) {
      Id = id;
      Nome = nome;
      Salario = salario;
    }

    public void AumentaSalario (double porc) {
      double sal = Salario * (porc / 100);
      Salario += sal;
    }

    public override string ToString () {
      return Id + ", " + Nome + ", R$ " + Salario;
    }
  }

}