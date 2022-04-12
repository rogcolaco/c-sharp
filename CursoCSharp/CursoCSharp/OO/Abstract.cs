using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Celular {

        public abstract string Assistente();

        public string Tocar() {
            return "Trim Trim Trim ...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá meu nome BixBy!";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Olá meu nome Siri!";
        }
    }

    internal class Abstract {

        public static void Executar() {

            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung(),
            };

            foreach (var c in celulares) {
                Console.WriteLine(c.Assistente());
                Console.WriteLine(c.Tocar());
            }
        }
    }
}
