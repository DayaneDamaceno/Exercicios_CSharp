using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_04_Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Insira um nome: ");
            nome = Console.ReadLine();

            ReadVogais(nome);

            Console.ReadKey();
        }

        static void ReadVogais(string nome)
        {
            for (int i = 0; i < nome.Length; i++)
            {
                if ("AEIOUaeiou".IndexOf(nome[i]) != -1)
                {
                    Console.Write($"{nome[i]} - ");
                }
            }
        }
    }
}
