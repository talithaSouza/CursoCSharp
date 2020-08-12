using System;

namespace CursoModificadores {
  class Calculator {
    //ref referencia a variavel original, ponteiro
    //variável com ref DEVE ser iniciada
    public static void Triple (ref int x) {
      x = x * 3;
    }

    //out joga o valor do resultado da função na variável result
    //variável com out não precisa ser iniciada
    public static void Triple (int oringin, out int result) {
      result = oringin * 3;
    }
  }
}