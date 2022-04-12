using System;
using System.IO;

namespace CursoCSharp.Api {

    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string? home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                            Environment.OSVersion.Platform == PlatformID.MacOSX)
                            ? Environment.GetEnvironmentVariable("HOME")
                            //: Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
                            : Environment.ExpandEnvironmentVariables("%ONEDRIVE%");

            return path.Replace("~", home);
            //return home;
        }
    }

    internal class PrimeiroArquivo {

        public static void Executar() {

            //var path = @"~/primeiro_arquivo.txt";
            var path = @"~/primeiro_arquivo.txt".ParseHome() ;

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("é possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto");
            }
        }
    }
}
