using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados {

    public class Caixa<T> {

        T valorPrivado;

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T Coisa { get; set; }

        public T MetodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }

    }

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(10) {
        }
    }

    class CaixaPessoa : Caixa<Pessoa> {
        public CaixaPessoa() : base(new Pessoa()) {
        }
    }

    internal class Genericos {

        public static void Executar() {

            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.MetodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.MetodoGenerico("caixa"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaPessoa caixa3 = new CaixaPessoa();
            Console.WriteLine(caixa3.Coisa.GetType().Name);

        }
    }
}
