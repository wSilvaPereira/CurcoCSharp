using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
   class Membros
   {
      public static void Executar()
      {
         Pessoa sicrano = new Pessoa();
         sicrano.Nome = "William";
         sicrano.Idade = 35;

         //Console.WriteLine(sicrano.Apresentar());

         sicrano.ApresentarNoConsole();
         sicrano.Zerar();
         sicrano.ApresentarNoConsole();

         var fulano = new Pessoa();
         fulano.Nome = "Ana";
         fulano.Idade = 35;

         var apresentacaoDoFulano = fulano.Apresentar();

         Console.WriteLine(apresentacaoDoFulano);
      }
   }
}
