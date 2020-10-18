using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
   public class SubCelebridade
   {
      //Todos
      public string InfoPublica = "Tenho um Instagram!";

      //Herança
      protected string CorDoOlho = "Verde";

      //Mesmo projeto (Assembly)
      internal ulong NumeroCelular = 5511999999999;

      //Herança ou no mesmo projeto
      protected internal string JeitoDeFalar = "Uso muitas gírias";

      //mesma classe ou herança no mesmo projeto (c# >= 7.2)
      private protected string SegredoFamilia = "Bla bla";

      //Private é o padrão
      bool UsaMuitoPhotoShop = true;

      public void MeusAcessos()
      {
         Console.WriteLine("Subcelebridade...");

         Console.WriteLine(InfoPublica);
         Console.WriteLine(CorDoOlho);
         Console.WriteLine(NumeroCelular);
         Console.WriteLine(JeitoDeFalar);
         Console.WriteLine(SegredoFamilia);
         Console.WriteLine(UsaMuitoPhotoShop);
      }
   }
}
