using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string Marca, string Modelo, int Cilindrada) {
            /*
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Cilindrada = Cilindrada;
            */

            SetMarca(Marca);
            SetModelo(Modelo);
            SetCilindrada(Cilindrada);
        }

        public Moto() {
        }

        public string GetMarca() {
            return Marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public int GetCilindrada() {
            return Cilindrada;
        }

        public void SetMarca(string Marca) {
            this.Marca = Marca;
        }

        public void SetModelo(string Modelo) {
            this.Modelo = Modelo;
        }

        public void SetCilindrada(int Cilindrada) {

            //if (Cilindrada > 0) {
            //    this.Cilindrada = Cilindrada;
            //}

            this.Cilindrada = Math.Abs(Cilindrada);
        }
    }

    internal class GetSet {
        public static void Executar() {

            Moto m = new Moto("Honda", "CB", 300);

            Console.WriteLine($"{m.GetMarca()}, {m.GetModelo()}, {m.GetCilindrada()}");

            Moto m2 = new Moto();

            m2.SetMarca("Yamaha");
            m2.SetModelo("r3");
            m2.SetCilindrada(-300);

            Console.WriteLine($"{m2.GetMarca()}, {m2.GetModelo()}, {m2.GetCilindrada()}");
        }
    }
}
