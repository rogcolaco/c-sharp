using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes {

    public class NegativoException : Exception {

        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException (string message, Exception innerException) : base(message, innerException) { }

    }

    public class ImparException : Exception {

        public ImparException(string message) : base(message) { }

    }
    internal class ExcecoesPersonalizadas {

        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30 , 30);

            if (valor < 0) {
                throw new NegativoException("Número Sorteado Negativo");
            }

            if (valor % 2 == 1) {
                throw new ImparException("Número Sorteado Impar");
            }

            return valor;
        }

        public static void Executar() {

            try {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException e) {
                Console.WriteLine(e.Message);
            }
            catch (ImparException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
