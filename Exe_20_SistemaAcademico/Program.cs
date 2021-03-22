using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_20_SistemaAcademico
{
    class Program
    {
        /*
         20. Sistema Acadêmico
            Faça um programa que solicite os seguintes dados de um aluno: nome, telefone, idade, valor da mensalidade.
            Ao final do programa, exiba os dados cadastrados.
            Validações:
            Nome deve ser preenchido, telefone deve ter exatamente 9 dígitos (contando o “-“)
            O primeiro dígito do celular não pode iniciar com 7,8 ou 9
            Idade deve estar entre 0 e 150 
            mensalidade deve ser >= 0.

         */

        struct Aluno
        {
            public string nome;
            public string telefone;
            public int idade;
            public double valorMensalidade;
        }

        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            bool repeat = false;

            do
            {
                Console.Write("Insira o nome do aluno: ");
                aluno1.nome = Console.ReadLine();

            } while (aluno1.nome == "");

            do
            {
                repeat = false;
                Console.Write("Insira o telefone do aluno: ");
                aluno1.telefone = Console.ReadLine();

                if ("789".IndexOf(aluno1.telefone[0]) != -1)
                {
                    Console.WriteLine("Não é valido telefone que comece com 7,8 ou 9");
                    repeat = true;
                }

            } while (aluno1.telefone.Length != 9 || repeat);

            do
            {
                try
                {
                    Console.Write("Insira a idade do aluno: ");
                    aluno1.idade = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Insira apenas idades de 1 a 150");
                }

            } while (aluno1.idade < 0 || aluno1.idade >= 150);

            do
            {
                try
                {
                    Console.Write("Insira o valor da mensalidade: ");
                    aluno1.valorMensalidade = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Insira apenas números maiores que 0");
                }

            } while (aluno1.valorMensalidade < 0);


            Console.WriteLine(aluno1.nome);
            Console.WriteLine(aluno1.telefone);
            Console.WriteLine(aluno1.idade);
            Console.WriteLine(aluno1.valorMensalidade);



            Console.ReadKey();
        }
    }
}
