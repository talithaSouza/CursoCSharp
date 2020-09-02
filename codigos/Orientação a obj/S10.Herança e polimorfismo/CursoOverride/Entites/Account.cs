namespace CursoOverride.Entites {
  public class Account {
    public int Number { get; protected set; }
    public string Holder { get; protected set; }
    public double Balace { get; protected set; }

    public Account () {

    }

    public Account (int number, string holder, double balace) {
      Number = number;
      Holder = holder;
      Balace = balace;
    }
  //PREFIXO VIRTUAL É USADO PARA QUE POSSA SER FEITO OVERRIDE NA FUNÇÃO
  //OVERRIDE:  SOBREPOSIÇÃO
    public virtual void Withdraw (double amount) {
      Balace -= amount + 5;
    }
  //------------------------------------------------------

    public void Deposit (double amount) {
      Balace += amount;
    }
  }
}