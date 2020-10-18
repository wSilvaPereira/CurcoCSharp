using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
   class EstruturaWhile
   {
      public static void Executar()
      {
         int palpite = 0;
         Random random = new Random();

         int numeroSecreto = random.Next(1, 16);
         bool numeroEncontrado = false;
         int tentativasRestantes = 5;
         int tentativas = 0;

         while (tentativasRestantes > 0 && !numeroEncontrado)
         {
            Console.Write("Insira seu palpite: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out palpite);

            tentativasRestantes--;
            tentativas++;

            if (numeroSecreto == palpite)
            {
               numeroEncontrado = true;
               var corAnterior = Console.BackgroundColor;
               Console.BackgroundColor = ConsoleColor.Red;
               Console.Write($"Número encontrado em {tentativas} tentativas");
               Console.BackgroundColor = corAnterior;
            }
            else if (palpite > numeroSecreto)
            {
               Console.WriteLine("Menor... Tente novamente!");               
            }
            else
            {
               Console.WriteLine("Maior...Tente novamente!");
            }

            if (!numeroEncontrado) {
               Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
               Console.WriteLine("");
            }
         }

         if (!numeroEncontrado)
         {
            Console.WriteLine($"O número secreto era {numeroSecreto}");
         }

      }
   }
}
