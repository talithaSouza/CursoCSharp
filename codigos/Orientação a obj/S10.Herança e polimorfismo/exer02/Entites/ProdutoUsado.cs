using System;

namespace exer02.Entites {
  class ProdutoUsado : Produto {
    public DateTime DataFabricacao { get; set; }

    public ProdutoUsado () {

    }

    public ProdutoUsado (string nome, double preco, DateTime dataFabricacao) 
    : base (nome, preco) {
      DataFabricacao = dataFabricacao;
    }

    public override string Etiqueta() {
      return Nome + "(usado) R$ "
             + Preco
             + " (Data de Fabricação: "
             + DataFabricacao.ToString("dd/MM/yyyy")
             +")";
    }

  }
}