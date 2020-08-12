using System.Globalization;

namespace Curso{

  class Produto{
    private string _nome;
    public  int Qtd { get; private set; }
		public double Preco { get; set; }


    public Produto(){

    }

    public Produto(string nome, double preco){
      _nome = nome;
      Preco = preco;
      Qtd = 5;
    }

    public double ValorTotalEmEstoque(){
      return Preco * Qtd;
    }

   public void AdicionarProdutos(int qtd){
     Qtd += qtd;

   }
   public void RemoverProdutos(int qtd){
     Qtd -= qtd;
   }

   public string Nome{
     get {return _nome;}
		 set{
			 if(value != null && value.Length >  1)
			 	_nome = value;
		 }
   }

   
   public override string ToString(){
     return _nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture)
            + ", "
            + Qtd
            + " unidades, Total: $"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
   }
  }
}