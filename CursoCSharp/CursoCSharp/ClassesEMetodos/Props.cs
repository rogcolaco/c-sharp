using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {

        private double desconto = 0.1;
        private string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente Leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //LAMBDA

            //get {
            //    return preco - (desconto * preco);
            //}
        }

        public CarroOpcional() {
        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome; //utilizou da props para chamar o set
            Preco = preco;
        }
    }

    internal class Props {

        public static void Executar() {

            var op1 = new CarroOpcional("Ar Condicionado", 3500);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 1200;

            Console.WriteLine(op2.Nome);

        }
    }
}
