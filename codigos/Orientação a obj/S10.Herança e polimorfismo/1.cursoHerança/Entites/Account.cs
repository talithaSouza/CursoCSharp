namespace cursoHerança.Entites {
  public class Account {
    public int Number { get; protected set; }
    public string Holder { get; protected set; }
    public double Balace { get; protected set; }

    public Account(){

    }

    public Account (int number, string holder, double balace) {
      Number = number;
      Holder = holder;
      Balace = balace;
    }

    public void Withdraw(double amount){
      Balace -= amount;
    }

    public void Deposit(double amount){
      Balace += amount;
    }
    

  }
}