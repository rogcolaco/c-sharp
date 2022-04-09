using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Pessoa {

        public string nome;
        public int idade;

        public Pessoa() {

        }
        
        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }

        public string Apresentar() {
            return string.Format($"Olá meu nome é {nome} e tenho {idade} anos");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

    }
}
