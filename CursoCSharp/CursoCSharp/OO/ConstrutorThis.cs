using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }


    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    internal class ConstrutorThis {

        public static void Executar () {

            Cachorro c1 = new Cachorro("Bud");
            Cachorro c2 = new Cachorro("Max", 40);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

        }
    }
}
