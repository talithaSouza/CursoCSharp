using System.Globalization;
using System;

namespace Questao3 {
  class Aluno {
    public double N1 = 0, N2 = 0, N3 = 0;
    public string Nome;


    public double NotaFinal () {
      return N1 + N2 + N3;
    }

    public void Situacao(){

      Console.WriteLine("Nota Final: " + NotaFinal().ToString("F1", CultureInfo.InvariantCulture));
      if(NotaFinal() >= 60)
        Console.WriteLine("APROVADO");
      else{
        double  nf =  60 - NotaFinal();
        Console.WriteLine("REPROVADO");
        Console.WriteLine("Faltaram: {0} Pontos", nf.ToString("F1",CultureInfo.InvariantCulture));
      }
    }

  }
}