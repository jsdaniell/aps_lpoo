using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motocicleta
{

    #region Partial Class
    public partial class Motocicleta : Form
    {
        public Motocicleta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void LigaDesliga(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || txtCor.Text == "")
            {
                MessageBox.Show("Você precisa criar uma moto para ligar!");
            } else if(stdMoto.Text == "Desligada")
            {
                stdMoto.Text = "Ligada";
                stdMoto.BackColor = Color.Green;
                stdMoto.ForeColor = Color.White;

                Moto motoMarcha = new Moto(txtMarca.Text, txtModelo.Text, txtCor.Text);

                stdMarcha.Text = motoMarcha.MenorMarcha.ToString();
            } else
            {
                stdMoto.Text = "Desligada";
                stdMoto.BackColor = Color.Gray;
                stdMoto.ForeColor = Color.Black;

                stdMarcha.Text = "Desligada";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtMarca.ReadOnly == true)
            {
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtCor.Text = "";

                txtMarca.ReadOnly = false;
                txtModelo.ReadOnly = false;
                txtCor.ReadOnly = false;

            } else if (txtMarca.Text == "" || txtModelo.Text == "" || txtCor.Text == "") {
                MessageBox.Show("Você precisa preencher todos os campos para criar uma moto!");
            } else
            {
                Moto novaMoto = new Moto(txtMarca.Text, txtModelo.Text, txtCor.Text);

                novaMoto.Marca = txtMarca.Text;
                this.txtMarca.Text = novaMoto.Marca;
                this.txtMarca.ReadOnly = true;

                novaMoto.Modelo = txtModelo.Text;
                this.txtModelo.Text = novaMoto.Modelo;
                this.txtModelo.ReadOnly = true;

                novaMoto.Cor = txtCor.Text;
                this.txtCor.Text = novaMoto.Cor;
                this.txtCor.ReadOnly = true;
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (stdMoto.Text == "Desligada")
            {
                MessageBox.Show("Você precisa ligar a moto para subir ou descer a marcha!");
            }
            else if (Convert.ToInt32(stdMarcha.Text) <= 4)
            {
               int marchaHandler = Convert.ToInt32(stdMarcha.Text) + 1;

                stdMarcha.Text = marchaHandler.ToString();

            } else
            {
                MessageBox.Show("Você não pode passar do limite de marcha!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (stdMoto.Text == "Desligada")
            {
                MessageBox.Show("Você precisa ligar a moto para subir ou descer a marcha!");
            }
            else if (Convert.ToInt32(stdMarcha.Text) >= 1)
            {
                int marchaHandler = Convert.ToInt32(stdMarcha.Text) - 1;

                stdMarcha.Text = marchaHandler.ToString();

            }
            else
            {
                MessageBox.Show("Você não descer a marcha mais do que isso!");
            }
        }
    }

    #endregion

    #region My Class

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


        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Marcha { get => marcha; set => marcha = value; }
        public int MenorMarcha { get => menorMarcha; set => menorMarcha = value; }
        public int MaiorMacha { get => maiorMacha; set => maiorMacha = value; }
        public bool EstaLigada { get => estaLigada; set => estaLigada = value; }

        public void MarchaAcima()
        {
            if (this.Marcha <= MaiorMacha && EstaLigada == true)
            {
                this.Marcha += 1;
                Console.WriteLine("Você subiu a marcha, a marcha atual é: " + this.Marcha);

            }
            else if (EstaLigada == false)
            {
                Console.WriteLine("A moto está desligada! Você não pode subir a marcha");
            }
            else
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
            if (EstaLigada == false)
            {
                return "A moto está desligada";
            }
            else
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
            }
            else
            {
                EstaLigada = false;
                Console.WriteLine("Você desligou a moto, seu estado atual é: " + EstadoAtual());
            }
        }
    }

    #endregion
}
