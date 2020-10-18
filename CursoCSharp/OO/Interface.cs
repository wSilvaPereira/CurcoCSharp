using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.OO
{

   interface OperacaoBinaria
   {
      int Operacao(int a, int b);
   }

   class Soma : OperacaoBinaria
   {
      public int Operacao(int a, int b)
      {
         return a + b;
      }
   }

   class Subtracao : OperacaoBinaria
   {
      public int Operacao(int a, int b)
      {
         return a - b;
      }

   }

   class Multiplicacao : OperacaoBinaria
   {
      public int Operacao(int a, int b)
      {
         return a * b;
      }

   }

   class Calculadora
   {
      List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
         {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()
         };

      public string ExecutarOperacoes(int a, int b)
      {
         String resultado = "";

         foreach (var op in operacoes)
         {
            resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
         }

         return resultado;
      }

   }

   class Interface
   {

      public static void Executar()
      {
         Calculadora calc = new Calculadora();
         Console.WriteLine(calc.ExecutarOperacoes(20, 5));
      }

   }
}
