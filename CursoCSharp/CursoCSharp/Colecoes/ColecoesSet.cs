using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    internal class ColecoesSet {

        public static void Executar() {

            Produto livro = new Produto("Game of Thrones", 49.9);

            //Estrutura homogênea, não indexada e não estática (quantidade dinâmica de posições)
            // Não aceita repetição de elementos
            var carrinho = new HashSet<Produto>();

            carrinho.Add(livro);
            foreach (Produto produto in carrinho) {
                Console.WriteLine(produto.Nome);
            }

            Console.WriteLine("--------------");

            var combo = new HashSet<Produto>() {
                new Produto ("Camiseta", 29.9),
                new Produto ("Bermuda", 49.9),
                new Produto ("meia", 9.9),
                new Produto ("sapato", 22.9)
            };

            foreach (Produto produto in combo) {
                Console.WriteLine(produto.Nome);
            }

            Console.WriteLine("--------------");

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            Console.WriteLine("--------------");

            //carrinho.RemoveAt(2);

            foreach (Produto produto in carrinho) {
                //Console.Write(carrinho.IndexOf(produto));
                Console.WriteLine(produto.Nome);
            }


        }
    }
}
