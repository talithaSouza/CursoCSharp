using System;

namespace FuncaoStrig {
  class Program {
    static void Main (string[] args) {
      string original = "abcde FGHIJ       ABC abc DEFG           ";

      string s1 = original.ToUpper ();                 //Transforma tudo em maiusculo
      string s2 = original.ToLower ();                 //Transforma tudo em minusculo
      string s3 = original.Trim ();                    //Retira espaços excessivos no final da string
      int n1 = original.IndexOf ("bc");                //Retorna a primeira ocorrencia da string procurada
      int n2 = original.LastIndexOf ("bc");            //Retorna a ultima ocorrencia da string procurada
      string s4 = original.Substring (3);              //Recorta a string a partir da posição indicada
      string s5 = original.Substring (3, 5);           //Recorta a string a partir da posição indicada com a qtd de caracteres indicadas
      string s6 = original.Replace ('a', 'x');         //troca toda ocorrencia de uma string por outra
      string s7 = original.Replace ("abc", "xy");      //troca ocorrencia de uma string por outra
      bool b1 = String.IsNullOrEmpty (original);       //Retorna se a string está vazia ou nulla
      bool b2 = String.IsNullOrWhiteSpace (original);  //Retorna se a string é só espaço

      Console.WriteLine ("Original: -" + original + "-");
      Console.WriteLine ("ToUpper: -" + s1 + "-");
      Console.WriteLine ("ToLower: -" + s2 + "-");
      Console.WriteLine ("Trim: -" + s3 + "-");
      Console.WriteLine ("IndexOf('bc'): " + n1);
      Console.WriteLine ("LastIndexOf('bc'): " + n2);
      Console.WriteLine ("Substring(3): -" + s4 + "-");
      Console.WriteLine ("Substring(3, 5): -" + s5 + "-");
      Console.WriteLine ("Replace('a', 'x'): -" + s6 + "-");
      Console.WriteLine ("Replace('abc', 'xy'): -" + s7 + "-");
      Console.WriteLine ("IsNullOrEmpty: " + b1);
      Console.WriteLine ("IsNullOrWhiteSpace: " + b2);
    }
  }
}