using System.Globalization;

namespace exer02.Entites {
  class ProdutoImportado : Produto {
    public double Taxa { get; set; }




    public ProdutoImportado(string nome, double preco, double taxa)
    : base(nome, preco){
        Taxa = taxa;
    }

    public double PrecoTotal(){
      return Preco + Taxa;
    }

    public override string Etiqueta(){
      return Nome + " R$ "
                  + PrecoTotal().ToString("F2",CultureInfo.InvariantCulture)
                  + " (Valor da Taxa: R$ " +  Taxa.ToString("F2",CultureInfo.InvariantCulture) 
                  + ")";
    }
  }
}