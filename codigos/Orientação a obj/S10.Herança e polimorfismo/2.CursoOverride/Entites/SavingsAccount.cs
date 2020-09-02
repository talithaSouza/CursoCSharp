namespace CursoOverride.Entites {
  public class SavingsAccount : Account {
    public double InterestRate { get; set; }

    public SavingsAccount () {

    }

    public SavingsAccount (int number, string holder, double balace, double interestRate) : base (number, holder, balace) {
      InterestRate = interestRate;
    }

    public void UpdateBalace(){
      Balace += Balace * InterestRate;
    }

  //OVERRIDE
    public override void Withdraw(double ammount){
      Balace -= ammount;
    }
  //-------------------------------------------------
    
  //APROVEITANDO O METODO DA SUPERCLASSE
    /*
    public override void Withdraw(double ammount){
      base.Withdraw(ammount);
      Balace -= 2;
    }
    */
  //-----------------------------------------------------

  }
}