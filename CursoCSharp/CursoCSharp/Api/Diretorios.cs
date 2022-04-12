using System;
using System.IO;

namespace CursoCSharp.Api {
    internal class Diretorios {

        public static void Executar() {

            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/UFSCar".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);
            Console.WriteLine("==Informações da pasta!==");

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            var arquivosDirInfo = dirInfo.GetFiles();
            foreach (var arquivo in arquivosDirInfo) {
                Console.WriteLine(arquivo);
            }

            var diretoriosDirInfo = dirInfo.GetDirectories();
            foreach (var diretorio in diretoriosDirInfo) {
                Console.WriteLine(diretorio);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);


            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("==Pastas==");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n \n ==Arquivos==");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Directory.Move(novoDir, novoDirDestino);

        }
    }
}
