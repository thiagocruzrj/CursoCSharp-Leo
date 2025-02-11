﻿using CursoCsharp.Api;
using CursoCsharp.ClassesEMetodos;
using CursoCsharp.Colecoes;
using CursoCsharp.EstruturasDeControle;
using CursoCsharp.Excecoes;
using CursoCsharp.Fundamentos;
using CursoCsharp.MetodosEFuncoes;
using CursoCsharp.OO;
using CursoCsharp.TopicosAvancados;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolação.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadore Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/ElseIf - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes e metodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e Métodos", DesafioAtributos.Executar},
                {"Parametros Variaveis - Classes e Métodos", ParametrosVariaveis.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Getters and Setters - Classes e Métodos", GetSet.Executar},
                {"Propriedades - Classes e Métodos", Propriedades.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parametro com valor padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Usando array - Coleções", UsandoArray.Executar},
                {"Usando listas - Coleções", UsandoListas.Executar},
                {"Usando Array List - Coleções", UsandoArrayList.Executar},
                {"Usando Set - Coleções", UsandoSet.Executar},
                {"Usando Queue - Coleções", UsandoQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", UsandoStack.Executar},
                {"Dicionario - Coleções", Dicionario.Executar},

                // Orientação a objetos
                {"Heranca - Orientação a objetos", Heranca.Executar},
                {"Construtor This - Orientação a objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a objetos", Encapsulamento.Executar},
                {"Polimorfismo - Orientação a objetos", Polimorfismo.Executar},
                {"Classes Abstratas - Orientação a objetos", ClassesAbstratas.Executar},
                {"Interfaces - Orientação a objetos", Interfaces.Executar},
                {"Sealed - Orientação a objetos", Sealed.Executar},

                // Metodos e Funções
                {"Lambda - Metodos e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegate - Metodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Metodos e Funções", UsandoDelegate.Executar},
                {"Delegate Com Funcoes Anonimas - Metodos e Funções", DelegateComFuncoesAnonimas.Executar},
                {"Delegates Como Parametros - Metodos e Funções", DelegatesComoParametros.Executar},
                {"Metodos De Extencao - Metodos e Funções", MetodosDeExtencao.Executar},

                // Exceções
                {"Exececao - Exceções", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api c#
                {"Primeiro arquivo - Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Api", LendoArquivos.Executar},
                {"Exemplo File Info - Api", ExemploFileInfo.Executar},
                {"Diretorios - Api", Diretorios.Executar},
                {"Exemplo Directory Info - Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path Info - Api", ExemploPath.Executar},
                {"Exemplo DateTime - Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Api", ExemploTimeSpan.Executar},

                // Tópicos Avançados
                {"LINQ1 - Tópicos avançados", LINQ1.Executar},
                {"LINQ2 - Tópicos avançados", LINQ2.Executar},
                {"Nullables - Tópicos avançados", Nullables.Executar},
                {"Exemplo Dynamic - Tópicos avançados", ExemploDynamic.Executar},
                {"Exemplo Generic - Tópicos avançados", ExemploGeneric.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}