using System;
using System.IO;

namespace CursoCSharp.Api {
    internal class LendoArquivos {

        public static void Executar() {

            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Quantidade");
                    sw.WriteLine("Caneta Bic;3.59;50");
                    sw.WriteLine("Pano de Prato;12.0;100");
                    sw.WriteLine("Borracha;2.89;75");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) {

                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
