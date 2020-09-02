namespace Upcastig_e_downcasting.Entites {
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
  }
}