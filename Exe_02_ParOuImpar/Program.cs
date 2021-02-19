using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_02_ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ParOuImpar(numero));

            Console.ReadKey();
        }

        static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
                return "Par";
            else
                return "Impar";
        }
    }
}
