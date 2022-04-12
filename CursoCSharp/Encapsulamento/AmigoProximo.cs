using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class AmigoProximo {

        public readonly SubCelebridade amiga = new SubCelebridade();


        public void MeusAcessos() {
            Console.WriteLine("Amigo Próximo...");

            Console.WriteLine(amiga.InfoPublica);

            //Atributo recebido apenas por herança (protected)
            //Console.WriteLine(amiga.CorDoOlho);

            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);

            //Atributo recebido apenas na mesma classe ou herança do mesmo projeto (private protected)
            //Console.WriteLine(amiga.SegredoDeFamilia);

            //Não tem acesso porque o atributo é privado (private)
            //Console.WriteLine(amiga.UsaMuitoPhotoShop);
        }

    }
}
