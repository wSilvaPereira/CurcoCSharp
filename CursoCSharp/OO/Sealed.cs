using CursoCSharp.OO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
   sealed class SemFilho
   {
      public double ValorDaFortuna()
      {
         return 1_407_033.65;
      }
   }

   class Avo
   {
      public virtual bool HonrarNomeFamilia()
      {
         return true;
      }
   }

   class Pai : Avo
   {
      public sealed override bool HonrarNomeFamilia()
      {
         return true;
      }
   }

   class FilhoRebelde : Pai
   {
      //public override bool HonrarNomeFamilia()
      //{
      //   return false;
      //}
   }

   class Sealed
   {
      public static void Executar()
      {
         SemFilho semfilho = new SemFilho();
         Console.WriteLine(semfilho.ValorDaFortuna());

         FilhoRebelde filho = new FilhoRebelde();
         Console.WriteLine(filho.HonrarNomeFamilia());

      }
   }
}
