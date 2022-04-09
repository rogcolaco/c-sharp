using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {


    internal class CalculadoraEstatica {

        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }


    internal class MetodosEstaticos {

        int a = 10;

        public static void Executar() {

            var resultado = CalculadoraEstatica.Multiplicar(3, 4);
            var resultado2 = CalculadoraEstatica.Somar(3, 4);

            MetodosEstaticos m = new MetodosEstaticos();
            Console.WriteLine(m.a);

        }
    }
}
