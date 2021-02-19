using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_01_PrimeiroNome
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[2];
            string primeiroNome;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º nome completo: ");
                nomes[i] = Console.ReadLine();

                primeiroNome = RetornaPrimeiroNome(nomes[i]);
                Console.WriteLine($"O primeiro nome é - {primeiroNome}");
            }
           
            Console.ReadLine();
        }

        static string RetornaPrimeiroNome(string nomeCompleto)
        {
            string primeiroNome;

            int indexSpace = nomeCompleto.IndexOf(" ");

            if (indexSpace == -1)
            {
                primeiroNome = nomeCompleto;
            }
            else
            {
                primeiroNome = nomeCompleto.Substring(0, indexSpace);
            }


            return primeiroNome;
        }
    }
}
