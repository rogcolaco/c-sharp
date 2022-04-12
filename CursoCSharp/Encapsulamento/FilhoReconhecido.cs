using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("Filho Reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);

            //Não tem acesso porque o atributo é privado (private)
            //Console.WriteLine(UsaMuitoPhotoShop);
        }

    }
}
