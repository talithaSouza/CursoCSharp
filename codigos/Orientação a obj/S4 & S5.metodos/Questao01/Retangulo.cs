using System.Globalization;
using System;

namespace Questao1 {
  
  class Retangulo {
    public double Altura, Largura;

    public double Area(){
      return (Largura * Altura);
    }

    public double Perimetro(){
      return (Largura + Altura) * 2;
    }

    public double Diagonal(){
      return Math.Sqrt((Largura * Largura) + (Altura * Altura));;
    }

    public override string ToString(){
      return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n"
              + "Perímetro = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n"
              + "Diagonal = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
    }
  }

}