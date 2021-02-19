using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_11_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Insira o {i + 1}º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(Somatoria(numeros));

            Console.ReadKey();

        }

        static int Somatoria(int[] numeros)
        {
            int soma = 0;

            for (int i = 0; i < 5; i++)
            {
                soma += numeros[i];
            }

            return soma;
        }
    }
}
