using System.Globalization;
using System;

namespace Statico {
	class ConversorDeMoedas {
		public static double IOF =  0.06;

    public static double ConverterEmDolar(double cotacao, double dolarComprar){
      dolarComprar += dolarComprar * IOF;
  
      return (cotacao * dolarComprar);
    }
	}
}