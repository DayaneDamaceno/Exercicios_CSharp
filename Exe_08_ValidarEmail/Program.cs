using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_08_ValidarEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;

            Console.WriteLine("Insira seu e-mail: ");
            email = Console.ReadLine();

            if (VerificaEmail(email))
                Console.WriteLine("E-mail é valido!");
            else
                Console.WriteLine("E-mail é invalido!");

            Console.ReadKey();
        }

        static bool VerificaEmail(string email)
        {
            int arroba = email.IndexOf('@');
            int ponto = email.IndexOf('.');

            if (arroba != -1 && ponto != -1)
            {
                if((arroba == 0) || (ponto == 0) || (arroba == email.Length - 1) || (ponto == email.Length - 1))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
