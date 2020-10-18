using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{

   public class FilhoNaoReconhecido : SubCelebridade
   {
      public new void MeusAcessos()
      {
         Console.WriteLine("FilhoNaoReconhecido...");

         Console.WriteLine(InfoPublica);
         Console.WriteLine(CorDoOlho);
         //Console.WriteLine(NumeroCelular);
         Console.WriteLine(JeitoDeFalar);
         //Console.WriteLine(SegredoFamilia);
         //Console.WriteLine(UsaMuitoPhotoShop);
      }
   }

   public class AmigoDistante
   {
      public readonly SubCelebridade amiga = new SubCelebridade();

      public void MeusAcessos()
      {
         Console.WriteLine("AmigoDistante...");

         Console.WriteLine(amiga.InfoPublica);
         //Console.WriteLine(amiga.CorDoOlho);
         //Console.WriteLine(amiga.NumeroCelular);
         //Console.WriteLine(amiga.JeitoDeFalar);
         //Console.WriteLine(amiga.SegredoFamilia);
         //Console.WriteLine(UsaMuitoPhotoShop);
      }
   }

   class Encapsulamento
   {
      public static void Executar()
      {
         new SubCelebridade().MeusAcessos();
         Console.WriteLine("");

         new FilhoReconhecido().MeusAcessos();
         Console.WriteLine("");

         new AmigoProximo().MeusAcessos();
         Console.WriteLine("");

         new FilhoNaoReconhecido().MeusAcessos();
         Console.WriteLine("");

         new AmigoDistante().MeusAcessos();
         Console.WriteLine("");
      }
   }
}
