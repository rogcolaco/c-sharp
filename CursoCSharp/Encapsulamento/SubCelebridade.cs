using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {

        //Todos acessam

        public string InfoPublica = "Tenho um instagram";

        //Transmitido por herança
        protected string CorDoOlho = "Verde";

        //Mesmo projeto (Assembly)
        internal ulong NumeroCelular = 551199999999;

        //Herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe ou herança do mesmo projeto (c# => 7.2)
        private protected string SegredoDeFamilia = "Bla bla";

        //private
        private bool UsaMuitoPhotoShop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoShop);
        }
    }
}
