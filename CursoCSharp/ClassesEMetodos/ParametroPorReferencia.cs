using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
   class ParametroPorReferencia
   {

      public static void AlterarRef(ref int numero)
      {
         numero += 1000;
      }

      public static void AlterarOut(out int numero)
      {
         numero = 0;
         numero += 15;
      }
      public static void Executar()
      {
         int a = 3;
         AlterarRef(ref a);
         Console.WriteLine(a);

         //int b = 2;
         AlterarOut(out int b);
         Console.WriteLine(b);
      }

   }
}
