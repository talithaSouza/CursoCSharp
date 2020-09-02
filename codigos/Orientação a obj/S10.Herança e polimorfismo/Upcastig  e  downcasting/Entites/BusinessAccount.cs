namespace Upcastig_e_downcasting.Entites {
  public class BusinessAccount : Account{
     public double LoanLimit { get; set; }

    public BusinessAccount () {

    }

    public BusinessAccount (int number, string holder, double balace, double loanLimit) 
      : base (number, holder, balace) {
        LoanLimit = loanLimit;
    }

    public void Loan(double ammount){
      if(ammount <= LoanLimit)
        Balace += ammount;
    }
  }
}