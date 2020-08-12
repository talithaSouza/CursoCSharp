using System;
using System.Globalization;

namespace Date_Time {
  class Program {
    static void Main (string[] args) {

      //Representa um instante
      /*DateTime d1 = DateTime.Now;
      Console.WriteLine (d1); //FORMATAÇÃO
      Console.WriteLine (d1.Ticks); //COMO É GUARDADA INTERNAMENTE
      */
      /*INSTANCIAR UMA DATA EM VARIOS FORMATOS
      DateTime d1 = new DateTime (2000, 8, 15);
      DateTime d2 = new DateTime (2000, 8, 15, 13, 5, 58);
      DateTime d3 = new DateTime (2000, 8, 15, 13, 5, 58, 275);
      Console.WriteLine (d1);
      Console.WriteLine (d2);
      Console.WriteLine (d3);
      */
      /*
      DateTime d1 = DateTime.Now;
      DateTime d2 = DateTime.UtcNow; //HORARIO GLOBAL
      DateTime d3 = DateTime.Today;  //HORARIO DO DIA A MEIA NOITE
      Console.WriteLine (d1);
      Console.WriteLine (d2);
      Console.WriteLine (d3);
      */
      /*CONVERTE UMA STRING PRA UM DATETIME
      DateTime d1 = DateTime.Parse ("2000-08-15");           //HORA 00:00:00
      DateTime d2 = DateTime.Parse ("2000-08-15 13:05:58");  //COM HORA
      DateTime d3 = DateTime.Parse ("15/08/2000");           //HORA 00:00:00
      DateTime d4 = DateTime.Parse ("15/08/2000 13:05:58");  //COM HORA
      Console.WriteLine (d1);
      Console.WriteLine (d2);
      Console.WriteLine (d3);
      Console.WriteLine (d4);
      */

      DateTime d1 = DateTime.ParseExact ("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
      DateTime d2 = DateTime.ParseExact ("15/08/2000 13:05:58", "dd/MM/yyyy hh:mm:ss",CultureInfo.InvariantCulture);
      Console.WriteLine (d1);
      Console.WriteLine (d2);

    }
  }
}