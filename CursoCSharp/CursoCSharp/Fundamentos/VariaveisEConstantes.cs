using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {

            //Área de Circunferência

            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine("Área é " + area);

            int unidade = 0;
            Console.WriteLine(unidade);

        }
    }
}
