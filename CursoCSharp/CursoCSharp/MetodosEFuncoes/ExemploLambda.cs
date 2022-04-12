using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes {
    internal class ExemploLambda {

        public static void Executar() {

            //Action não tem retorno
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            //Action não tem retorno <tipo de parametro>
            Action<string> algoNovoNoConsole = (text) => {
                Console.WriteLine($"Lambda com C#! {text}");
            };

            //Func tem retorno <tipo de retorno>
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            //Func tem retorno <parametro, tipo de retorno>
            Func<int, string> conversorHex = (numero) => {
                return numero.ToString("X");
            };

            //Func tem retorno <parametro, tipo de retorno>
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2}", dia, mes, ano);

            algoNoConsole();
            algoNovoNoConsole("Valor passado por parâmetro!");
            Console.WriteLine(jogarDado());
            Console.WriteLine(conversorHex(1234));
            Console.WriteLine(formatarData(14, 6, 85));

        }
    }
}
