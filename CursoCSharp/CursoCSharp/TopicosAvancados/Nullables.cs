using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    internal class Nullables {

        //Valor inicializado por padrão por se tratar de uma variável de classe
        //Valor padrão int = 0
        static int num3;
        
        public static void Executar() {

            Nullable<int> num1 = null;

            int? num2 = null;

            //Uso de variável de classe;
            Console.WriteLine(num3);

            if (num1.HasValue) {
                Console.WriteLine($"Valor de num1: {num1}");
            }
            else {
                Console.WriteLine("A variável não possui valor");
            }

            //valor em padrão para quando a variável que está sendo atribuída é nullable
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            //valor em padrão para quando a variável que está sendo atribuída é nullable (bool)
            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.Value;
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
