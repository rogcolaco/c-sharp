using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {

        public static void Executar() {

            double valor = 15.175;

            //Float e quantidade de casas decimais
            Console.WriteLine(valor.ToString("F1"));

            //Currency
            Console.WriteLine(valor.ToString("C"));

            //Percentual * 100
            Console.WriteLine(valor.ToString("P"));

            //Outra formatação que pemite definir casas decimais com arredondamento
            Console.WriteLine(valor.ToString("#.##"));

            //Define o local da aplicação BR
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            //Define o local da aplicação US
            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C2", cultura2));

            //Completa com zeros à esquerda até a posição definida
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
