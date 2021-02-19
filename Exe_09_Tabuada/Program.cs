using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_09_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Insira um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            ReadTabuada(numero);

            Console.ReadKey();
        }

        static void ReadTabuada(int numero)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i*numero}");
            }
        }
    }
}
