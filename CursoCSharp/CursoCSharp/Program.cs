using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},

                // Estruturas de Controle
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Metodos Estaticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Getters e Setters - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Parametros por Referência (ref e out) - Classes e Métodos", ParametrosPorReferencia.Executar},

                //Coleçoes
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", colecoesQueue.Executar},
                {"Dicionários - Coleções", ColecoesDictionary.Executar},

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor 'This' - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Classes Abstratas - OO", Abstract.Executar},
                {"Interfaces - OO", Interfaces.Executar},

                //Métodos e Funções (Lambda)
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Delegate com Lambda - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegate.Executar},
                {"Usando Delegates com Func. Anonimas - Métodos e Funções", DelegadeFunAnonima.Executar},
                {"Delegates como Parametros - Métodos e Funções", DelegatesComoParametros.Executar},

                //Tratamento de Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //Trabalhando com Arquivos e API
                {"Primeiro Arquivo - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - API", LendoArquivos.Executar},
                {"Exemplo FileInfo - API", ExemploFileInfo.Executar},
                {"Diretorios - API", Diretorios.Executar},
                {"Exemplo Path - API", ExemploPath.Executar},
                {"Exemplo DateTime - API", ExemploDateTime.Executar},

                //Topicos Avancados
                {"LINQ1 - Topicos Avançados", LINQ1.Executar},
                {"LINQ2 - Topicos Avançados", LINQ2.Executar},
                {"Nullables - Topicos Avançados", Nullables.Executar},
                {"Dynamics - Topicos Avançados", Dynamics.Executar},
                {"Genéricos - Topicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}