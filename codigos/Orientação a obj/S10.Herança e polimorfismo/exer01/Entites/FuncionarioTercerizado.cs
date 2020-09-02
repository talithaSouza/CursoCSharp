namespace exer01.Entites {
  class FuncionarioTercerizado : Funcionario {
    public double AdicionalDeGastos { get; set; }

    public FuncionarioTercerizado () {

    }

    public FuncionarioTercerizado (string nome, int horas, double valorPorHora, double adicionalDeGastos)
    : base(nome, horas, valorPorHora) {
      AdicionalDeGastos = adicionalDeGastos;
    }

    public override double Pagamento(){
      return  base.Pagamento() + (AdicionalDeGastos * 1.1);
    }
  }
}