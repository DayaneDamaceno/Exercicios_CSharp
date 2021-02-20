using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_10_MenorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"O menor número é - {MenorValor(numeros)}");

            Console.ReadKey();

        }

        static int MenorValor(int[] valores)
        {
            int menorNumero = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                if (i == 0) menorNumero = valores[0];
                else
                {
                    if (valores[i] < menorNumero) 
                        menorNumero = valores[i];
                }

            }

            return menorNumero;
        }
    }
}
