using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class colecoesQueue {

        public static void Executar() {

            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());

            Console.WriteLine(fila.Count);

            foreach (var item in fila) {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var item in fila) {
                Console.WriteLine(item);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains(3.14));


        }
    }
}
