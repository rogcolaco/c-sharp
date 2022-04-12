using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : SubCelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("Filho não Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);

            //Atributo acessível apenas no mesmo projeto (internal)
            //Console.WriteLine(NumeroCelular);
            
            Console.WriteLine(JeitoDeFalar);

            //Atributo recebido apenas na mesma classe ou herança do mesmo projeto (private protected)
            //Console.WriteLine(SegredoDeFamilia);

            //Não tem acesso porque o atributo é privado (private)
            //Console.WriteLine(UsaMuitoPhotoShop);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade conhecida = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante...");

            Console.WriteLine(conhecida.InfoPublica);

            //Atributo recebido apenas por herança (protected)
            //Console.WriteLine(conhecida.CorDoOlho);

            //Atributo acessado apenas no mesmo projeto (internal)
            //Console.WriteLine(conhecida.NumeroCelular);

            //Atributo recebido apenas por herança ou no mesmo proejeto (internal protected)
            //Console.WriteLine(conhecida.JeitoDeFalar);

            //Atributo recebido apenas na mesma classe ou herança do mesmo projeto (private protected)
            //Console.WriteLine(conhecida.SegredoDeFamilia);

            //Não tem acesso porque o atributo é privado (private)
            //Console.WriteLine(conhecida.UsaMuitoPhotoShop);
        }


    }
    internal class Encapsulamento {

        public static void Executar() {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();

        }
    }
}
