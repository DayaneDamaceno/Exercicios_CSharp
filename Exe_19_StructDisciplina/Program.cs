using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_19_StructDisciplina
{
    class Program
    {
        /*
         19. Faça um programa para gravar os seguintes dados de uma disciplina:
            nome : string; Não pode estar vazio
            nota de aprovação : int ; Entre 1 e 10
            Ao final exiba os dados no formato nome – nota de aprovação 
         */

        struct Disciplina
        {
            public string nome;
            public int notaAprovacao;
        }

        static void Main(string[] args)
        {
            Disciplina disciplina1 = new Disciplina();

            do
            {
                Console.Write("Insira o nome da disciplina: ");
                disciplina1.nome = Console.ReadLine();

            } while (disciplina1.nome == "");

            do
            {
                try
                {
                    Console.Write($"Insira a nota de aprovação para {disciplina1.nome}: ");
                    disciplina1.notaAprovacao = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Insira apenas números de 1 a 10");
                }

            } while (disciplina1.notaAprovacao <= 0 || disciplina1.notaAprovacao > 10);


            Console.WriteLine(disciplina1.nome);
            Console.WriteLine(disciplina1.notaAprovacao);

            Console.ReadKey();

        }
    }
}
