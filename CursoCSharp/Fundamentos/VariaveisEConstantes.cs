using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
   class VariaveisEConstantes
   {
      public static void Executar()
      {
         // área da circunferência
         double raio = 4.5;
         const double PI = 3.14;

         raio = 5.5;

         double area = PI * raio * raio;
         Console.WriteLine(area);
         Console.WriteLine("Área é " + area);

         // Tipos Internos

         bool estaChovendo = false;
         Console.WriteLine("Está chovendo " + estaChovendo);

         byte idade = 45;
         Console.WriteLine("Idade " + idade);

         sbyte saldoDeGols = sbyte.MinValue;
         Console.WriteLine("Saldo de gols " + saldoDeGols);

         short salario = short.MaxValue;
         Console.WriteLine("Salário " + salario);

         int menorValorInt = int.MinValue;
         Console.WriteLine("Menor valor inteiro" + menorValorInt);

         uint populacaoBrasileira = 207_600_000;
         Console.WriteLine("População brasileira " + populacaoBrasileira);

         long menorValorLong = long.MinValue;
         Console.WriteLine("Menor valor long " + menorValorLong);

         ulong populacaoMundial = 7_600_000_000;
         Console.WriteLine("População Mundial " + populacaoMundial);

         float precoComputador = 1299.99f;
         Console.WriteLine("Preço do computador " + precoComputador);

         double valorDeMercadoApple = 1_000_000_000_000.00;
         Console.WriteLine("ValorApple " + valorDeMercadoApple);

         decimal distanciaEntreEstrelas = decimal.MinValue;
         Console.WriteLine("Distância entre estrela " + distanciaEntreEstrelas);

         char letra = 'b';
         Console.WriteLine("Letra " + letra);

         string texto = "Seja bem vindo ao curso de c#";
         Console.WriteLine("Texto " + texto);

      }
   }
}
