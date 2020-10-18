using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{

   delegate double Operacao(double x, double y);

   class LambdasDelegate
   {
      public static void Executar()
      {
         Operacao Sum  = (x, y) => x + y;
         Operacao Sub  = (x, y) => x - y;
         Operacao Mult = (x, y) => x * y;

         Console.WriteLine(Sum(3, 3));
         Console.WriteLine(Sub(5, 2));
         Console.WriteLine(Mult(12, 8));
      }
   }
}
