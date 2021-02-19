using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_03_NumPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(VerificaPrimo(numero));

            Console.ReadKey();
        }

        static string VerificaPrimo(int numero)
        {
 
            int divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    divisores++;  
            }

            if (divisores == 2) return $"{numero} é primo.";
            else return $"{numero} não é primo.";

        }
    }
}
