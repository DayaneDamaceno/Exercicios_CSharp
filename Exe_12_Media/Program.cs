    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_12_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"O média dos números é - {Media(numeros)}");

            Console.ReadKey();
        }

        static int Media(int[] numeros)
        {
            int media = 0, soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            media = soma / numeros.Length;

            return media;
        }
    }
}
