using System;

namespace InterfaceLPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface  IValidador
    {
        bool ValidarDocumentos();
    }

    public class Pessoa : IValidador
    {
        public string nome;

        public void escreverNome()
        {
            Console.WriteLine("Nome: " + nome);
        }

        public bool ValidarDocumentos()
        {
            throw new NotImplementedException();
        }
    }

    public class Juridica : Pessoa
    {
        string cnpj;

        public bool ValidarDocumentos()
        {
            throw new NotImplementedException();
        }

    }

    public class Fisica : Pessoa
    {
        string cpf;

        public bool ValidarDocumentos()
        {
            throw new NotImplementedException();
        }
    }
}
