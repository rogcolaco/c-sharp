using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

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

            });

            central.SelecionarEExecutar();
        }
    }
}