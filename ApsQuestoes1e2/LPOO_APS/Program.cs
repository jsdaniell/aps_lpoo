using System;

namespace LPOO_APS
{
    class Program
    {
        static void Main(string[] args)
        {

 

            var aluno1 = new Aluno();

            aluno1 = Aluno.ComMatricula("Daniel", 123456);

            aluno1.ImprimirNome();
            aluno1.ImprimirMatricula();
            aluno1.ImprimirCpf();

            var aluno2 = new Aluno();
            aluno2 = Aluno.ComCpfEMatricula("Clara", 54321, 456789);

            aluno2.ImprimirNome();
            aluno2.ImprimirMatricula();
            aluno2.ImprimirCpf();
        }
    }

    class Aluno
    {

        /* Pelo que li na especificação existe uma indicação sobre não declarar dois ou mais construtores com a mesma
         * parametrização, então recorri ao factory method, que encaixa muito bem nesse tipo de situação.
         * Poderia também criar os tipos matricula e cpf, porém julguei ser menos prático nesse caso. */

        public static Aluno ComMatricula(String nomeCompleto,int matricula)
        {
            var aluno = new Aluno();
            aluno.nomeCompleto = nomeCompleto;
            aluno.matricula = matricula;
            return aluno;
        }

        public static  Aluno ComCpf(String nomeCompleto, int cpf)
        {
            var aluno = new Aluno();
            aluno.nomeCompleto = nomeCompleto;
            aluno.cpf = cpf;
            return aluno;
        }

        public static Aluno ComCpfEMatricula(String nomeCompleto, int matricula, int cpf)
        {
            var aluno = new Aluno();
            aluno.nomeCompleto = nomeCompleto;
            aluno.matricula = matricula;
            aluno.cpf = cpf;
            return aluno;
        }


        private String nomeCompleto;

        private int matricula;

        private int cpf;

        public void ImprimirNome()
        {
            Console.WriteLine(nomeCompleto);
        }

        public void ImprimirMatricula()
        {
            if (matricula == 0)
            {
                Console.WriteLine("Não foi registrada a matricula do aluno");
            }
            else
            {
                Console.WriteLine(matricula);
            }
        }

        public void ImprimirCpf()
        {
            if(cpf == 0)
            {
                Console.WriteLine("Não foi registrado o CPF do aluno");
            } else
            {
                Console.WriteLine(cpf);
            }
        }


    }
}
