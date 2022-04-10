using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {

        public static void Executar() {

            //Estrutura homogênea, indexada e estática (quantidade fixa de posições)
            string[] alunos = new string[5];

            alunos[0] = "Rogerio";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            //foreach (var nota in notas) {
            //    somatorio += nota;
            //}

            for (int i = 0; i < notas.Length; i++) {
                somatorio += notas[i];
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            letras[2] = 'R';
            string palavra = new string(letras).ToUpper();
            Console.WriteLine(palavra);
        }
    }
}
