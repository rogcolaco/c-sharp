using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class LINQ2 {

        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno { Nome = "Ana", Idade = 21, Nota = 4.3 },
                new Aluno { Nome = "Andre", Idade = 20, Nota = 9.5 },
                new Aluno { Nome = "Jorge", Idade = 21, Nota = 8.5 },
                new Aluno { Nome = "Ana", Idade = 22, Nota = 7.7 },
                new Aluno { Nome = "Julia", Idade = 18, Nota = 7.5 },
                new Aluno { Nome = "Marcio", Idade = 25, Nota = 6.8 },
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");
            
            
            var funlano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (funlano == null) {
                Console.WriteLine("Aluno inexistente");
            }
            
            //Também existe a função Last
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"{ana.Nome} {ana.Nota}");

            //Também existe a função LastOrDefault
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno inexistente");
            }

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var aluno in exemploSkip) {
                Console.WriteLine(aluno.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine($"{maiorNota}");

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine($"{menorNota}");

            var somatorioNotas = alunos.Sum(alunos => alunos.Nota);
            Console.WriteLine($"{somatorioNotas}");

            var mediaNotas = alunos.Average(alunos => alunos.Nota);
            Console.WriteLine($"{mediaNotas}");

            //Media de alunos aprovados
            //Seleção de parte do todo
            var mediaNotasAprovados = alunos.Where(a => a.Nota >=7).Average(alunos => alunos.Nota);
            Console.WriteLine($"{mediaNotasAprovados}");
        }
    }
}
