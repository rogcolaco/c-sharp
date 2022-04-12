using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {
    
    interface OperacaoBinaria {
        int Operacao(int a, int b);
    }

    public class Soma : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a + b; ;
        }
    }

    public class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b; ;
        }
    }

    public class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b; ;
        }
    }

    public class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma (),
            new Subtracao (),
            new Multiplicacao (),
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (OperacaoBinaria operacao in operacoes) {
                resultado += $"Usando {operacao.GetType().Name} = {operacao.Operacao(a, b)} \n";
            }

            return resultado;
        }
    }

    internal class Interfaces {

        public static void Executar() {

            Calculadora calculadora = new Calculadora();
            var resultado = calculadora.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);

        }
    }
}
