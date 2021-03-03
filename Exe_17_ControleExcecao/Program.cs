using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_17_ControleExcecao
{
    class Program
    {

        /*
         Solicite o código, o salário e a data de nascimento de um aluno. Caso ele digite valores incorretos, solicite-os
         novamente. Utilize o controle de exceção. Ao final, mostre os valores.
         */

        static void Main(string[] args)
        {
            double cod, salario;
            DateTime nascimento;

            cod = ExcecaoNumero("Insira seu código de indentificação: ");
            salario = ExcecaoNumero("Insira seu salário: ");
            nascimento = ExcecaoData("Insira sua data de nascimento: ");

            Console.WriteLine($"\nCódigo - {cod} \nSalário - {salario.ToString("C")} \nData de Nascimento - {nascimento.ToShortDateString()}");

            Console.ReadKey();

        }

        static double ExcecaoNumero(string mensagem)
        {
            double valor = 0;
            do
            {
                try
                {
                    Console.Write(mensagem);
                    valor = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nPor favor digite apenas números!!\n");

                }
            } while (true);

            return valor;
        }
        static DateTime ExcecaoData(string mensagem)
        {
            DateTime data;
            do
            {
                try
                {
                    Console.Write(mensagem);
                    data = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("\nPor favor digite uma data valida!!\n");

                }
            } while (true);

            return data;
        }
    }
}
