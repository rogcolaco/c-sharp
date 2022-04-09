using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {

        public static void Executar() {

            Pessoa p = new Pessoa();
            p.nome = "Rogério";
            p.idade = 36;

            Console.WriteLine("Utilizando atributos em outra classe");
            Console.WriteLine($"O nome da pessoa é {p.nome} e ele tem {p.idade}");

            Console.WriteLine("\n");
            Console.WriteLine("Utilizando retorno de método");
            string apresentação = p.Apresentar();
            Console.WriteLine(apresentação);

            Console.WriteLine("\n");
            Console.WriteLine("Utilizando método que chama no console");
            p.ApresentarNoConsole();
        }
    }
}
