using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_07_VerificaSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Insira um texto:");
            texto = Console.ReadLine();

            if (VerificaSpace(texto))
                Console.WriteLine("O seu texto tem espaços");
            else
                Console.WriteLine("O seu texto não tem espaços");


            Console.ReadKey();

        }

        static bool VerificaSpace(string texto)
        {
            if (texto.IndexOf(" ") != -1)
                return true;
            else
                return false;
        }
    }
}
