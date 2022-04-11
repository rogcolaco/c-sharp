using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesDictionary {

        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine($"2004: {filmes[2004]}");
                Console.WriteLine($"2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Aminésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine(filme2006);

            foreach (var key in filmes.Keys) {
                Console.WriteLine(key);
            }

            foreach (var value in filmes.Values) {
                Console.WriteLine(value);
            }

            foreach (KeyValuePair<int,string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            Console.WriteLine("----------------------------");

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
