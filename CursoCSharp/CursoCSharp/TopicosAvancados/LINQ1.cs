using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    internal class LINQ1 {

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

            Console.WriteLine("==Aprovados==");
            int count = 0;
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);
            Console.WriteLine(aprovados.GetType().Name);
            foreach (var aluno in aprovados) {
                Console.WriteLine(count + ") " + aluno.Nome + " Nota: " + aluno.Nota);
                count++;
            }

            Console.WriteLine("==Chamada==");
            count = 0;
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            Console.WriteLine(chamada.GetType().Name);
            foreach (var aluno in chamada) {
                Console.WriteLine(count + ") " + aluno);
                count++;
            }

            Console.WriteLine("==Aprovados por Idade==");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            Console.WriteLine(alunosAprovados.GetType().Name);
            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
