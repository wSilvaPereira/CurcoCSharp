using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

namespace CursoCSharp
{
   class Program
   {
      static void Main(string[] args)
      {
         var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternario - Fundamentos", OperadorTernario.Executar},
                //Estruturas de controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas de controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de controle", UsandoContinue.Executar},
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"ReadOnly - Classes e Métodos", ReadOnly.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParametroPorReferencia.Executar},
                {"Parâmetro Padrão - Classes e Métodos", ParametroPadrao.Executar},
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"Coleções List - Coleções", ColecoesList.Executar},
                {"Coleções ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Coleções Set - Coleções", ColecoesSet.Executar},
                {"Coleções Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Coleções Stack - Coleções", ColecoesStack.Executar},
                {"Coleções Dictionary - Coleções", ColecoesDictionary.Executar},
                //OO
                {"Herança - Orientação de Objeto", Heranca.Executar},
                {"Construtor This - Orientação de Objeto", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação de Objeto", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação de Objeto", Polimorfismo.Executar},
                {"Abstract - Orientação de Objeto", Abstract.Executar},
                {"Interface - Orientação de Objeto", Interface.Executar},
                {"Sealed - Orientação de Objeto", Sealed.Executar},

                //Métodos & funções
                {"Exemplo Lambda - Métodos % Funções", ExemploLambda.Executar},
                {"Lambdas com Delegates - Métodos % Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos % Funções", UsandoDelegates.Executar},
                {"Delegates com Função Anonima - Métodos % Funções", DelegatesFunAnonima.Executar},
                {"Delegates Como Parametros - Métodos % Funções", DelegatesComoParametros.Executar},
                {"Metodos De Extensão - Métodos % Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceções - Exceções", PrimeiraExcecao.Executar},

            });

         central.SelecionarEExecutar();
      }
   }
}