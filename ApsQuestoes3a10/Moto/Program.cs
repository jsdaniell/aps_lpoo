using System;

namespace Moto
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto motinha = new Moto("Yamaha", "Z7H1", "Azul");

            motinha.Imprimir();
            motinha.LigarDesligar();
            motinha.MarchaAcima();
            motinha.MarchaAbaixo();
            motinha.MarchaAbaixo();
            motinha.MarchaAbaixo();

            motinha.LigarDesligar();
            motinha.MarchaAcima();
            motinha.MarchaAbaixo();

        }
    }

    public class Moto
    {
        String marca;
        String modelo;
        String cor;
        int marcha = 0;
        int menorMarcha = 0;
        int maiorMacha = 5;
        bool estaLigada = false;

        // Construtor 1
        public Moto(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }

        public Moto(string marca, string modelo, string cor, int marcha, int menorMarcha, int maiorMacha, bool estaLigada) : this(marca, modelo, cor)
        {
            Marcha = marcha;
            MenorMarcha = menorMarcha;
            MaiorMacha = maiorMacha;
            EstaLigada = estaLigada;
        }

        // Construtor 2



        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Marcha { get => marcha; set => marcha = value; }
        public int MenorMarcha { get => menorMarcha; set => menorMarcha = value; }
        public int MaiorMacha { get => maiorMacha; set => maiorMacha = value; }
        public bool EstaLigada { get => estaLigada; set => estaLigada = value; }

        public void Imprimir()
        {
            Console.WriteLine("A marca da sua moto é: " + this.Marca);
            Console.WriteLine("O modelo da sua moto é: " + this.Modelo);
            Console.WriteLine("A cor da sua moto é: " + this.Cor);
            Console.WriteLine("A marcha atual é: " + this.Marcha);
            Console.WriteLine("A marcha mínima aceita é: " + MenorMarcha);
            Console.WriteLine("A marcha máxima aceita é: " + MaiorMacha);
            Console.WriteLine("Estado atual: " + EstadoAtual());
        }

        public void MarchaAcima()
        {
            if (this.Marcha <= MaiorMacha && EstaLigada == true)
            {
                this.Marcha += 1;
                Console.WriteLine("Você subiu a marcha, a marcha atual é: " + this.Marcha);
                
            } else if(EstaLigada == false) {
                Console.WriteLine("A moto está desligada! Você não pode subir a marcha");
            } else
            {
                Console.WriteLine("Você não pode subir a marcha, já está no máximo!");
            }
        }

        public void MarchaAbaixo()
        {
            if (this.Marcha >= 1 && EstaLigada == true)
            {
                this.Marcha -= 1;
                Console.WriteLine("Você desceu a marcha, a marcha atual é: " + this.Marcha);
            }
            else if (EstaLigada == false)
            {
                Console.WriteLine("A moto está desligada! Você não pode descer a marcha");
            }
            else
            {
                Console.WriteLine("Você está no neutro, não pode descer mais do que isso! Sua marcha atual é: " + this.Marcha);
            }
        }

        public String EstadoAtual()
        {
            if(EstaLigada == false)
            {
                return "A moto está desligada";
            } else
            {
                return "A moto está ligada";
            }
        }

        public void LigarDesligar()
        {
            if (EstaLigada == false)
            {
                EstaLigada = true;
                Console.WriteLine("Você ligou a moto, seu estado atual é: " + EstadoAtual());
            } else
            {
                EstaLigada = false;
                Console.WriteLine("Você desligou a moto, seu estado atual é: " + EstadoAtual());
            }
        }
    }
}
