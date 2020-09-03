using System.Globalization;

namespace exer02.Entites {
  class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; } 
    
    public Produto(){

    }

    public Produto (string nome, double preco) {
      Nome = nome;
      Preco = preco;
    }

    public virtual string Etiqueta(){
      return Nome + " R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}