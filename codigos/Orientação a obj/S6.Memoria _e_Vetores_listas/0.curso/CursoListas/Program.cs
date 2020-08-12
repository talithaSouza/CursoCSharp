using System;
using System.Collections.Generic;

namespace CursoListas {
  class Program {
    static void Main (string[] args) {

      List<string> lista = new List<string> ();

      lista.Add ("Maria"); // adiciona no final da lista
      lista.Add ("Alex");
      lista.Add ("Bob");
      lista.Add ("Ana");
      lista.Insert (1, "Talitha"); //insere na posição indicada

      foreach (string nome in lista) {
        Console.WriteLine (nome);
      }
      Console.WriteLine (lista.Count); // retorna o tamanho da lista

      string s1 = lista.Find (x => x[0] == 'C'); //find com a expressão lambda(função resumida)
      Console.WriteLine ("Fist 'C':" + s1); //find()retora a primeira ocorrência de uma condição

      string s2 = lista.FindLast (x => x[0] == 'A'); //retorna a ultima ocorrência de uma condição
      Console.WriteLine ("Last 'A': " + s2);

      int pos1 = lista.FindIndex (x => x[0] == 'C'); //retorna a posição da primeira ocorrência de uma condição
      Console.WriteLine ("Fist position 'C': " + pos1);

      int pos2 = lista.FindLastIndex (x => x[0] == 'A'); //retorna a posição da primeira ocorrência de uma condição
      Console.WriteLine ("last position 'A': " + pos2);

      List<string> lista2 = new List<string> ();
      lista2 = lista.FindAll (x => x.Length >= 5); //retorna uma lista com os elementos que satisfação a condição
      Console.WriteLine ("-------------");
      foreach (string s in lista2) {
        Console.WriteLine(s);
      }

      Console.WriteLine ("-------------");
      lista.Remove("Alex"); //remove o elemento especificado
      foreach (string s in lista) { //caso não encontre o elemento não faz nada
        Console.WriteLine(s);
      }

      Console.WriteLine ("-------------");
      lista.RemoveAll(x => x[0] == 'M'); //remove os elementos de acordo com a condição
      foreach (string s in lista) {
        Console.WriteLine(s);
      }

      Console.WriteLine ("-------------");
      lista.RemoveAt(1);
      foreach (string s in lista) {
        Console.WriteLine(s);
      }

      Console.WriteLine ("-------------");
      lista.RemoveRange(0,2); //remove a partir da posição indicada a quantidade de elementos especificadas
      foreach (string s in lista) {
        Console.WriteLine(s);
      }

    }
    //função de teste para Find()
    static bool Test (string s) {
      return s[0] == 'A';
    }
  }
}