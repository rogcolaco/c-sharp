using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaWhile {
        public static void Executar() {

            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            //Background Color Console
            var corBackgroundAnterior = Console.BackgroundColor;
            // Font color Console
            var corFonteAnterior = Console.ForegroundColor;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("De um palpite para o número secreto de 1 a 15: ");
                int.TryParse(Console.ReadLine(), out palpite);
                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto) {
                    numeroEncontrado = true;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Parabéns você encontrou o número secreto na sua tentativa {tentativas}");
                    Console.BackgroundColor = corBackgroundAnterior;
                    Console.ForegroundColor = corFonteAnterior;
                } else {
                    string msg = palpite > numeroSecreto ? "Palpite Maior que o número secreto" : "Palpite menor que o número secreto";
                    Console.WriteLine($"{msg} tentativas restantes {tentativasRestantes}");
                }
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("FIM DE JOGO!");
            Console.BackgroundColor = corBackgroundAnterior;
            Console.ForegroundColor = corFonteAnterior;

        }
    }
}
