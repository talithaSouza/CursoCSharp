using System.Globalization;
namespace Questao2 {

  class Funcionario {
    public string Nome;
    public double SalBruto, Imposto;

    public double SalarioLiquido(){
      return (SalBruto - Imposto);
    }

    public void AumentaSalario(float porcent){
      SalBruto += (SalBruto * porcent) / 100;
      
    }

    public override string ToString(){
      return  Nome + ", "
              + "R$ "
              + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}