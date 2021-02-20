using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_06_MetodosString
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            char inicial, final;

            Console.WriteLine("Insira um texto: ");
            texto = Console.ReadLine();

            Console.WriteLine("Insira uma letra que você quer trocar: ");
            inicial = Console.ReadLine()[0];

            Console.WriteLine($"Você quer trocar '{inicial}' por qual letra? -  ");
            final = Console.ReadLine()[0];

            UltimaLetra(texto);

            Console.WriteLine(TrocarCaracter(texto, inicial, final));

            Console.WriteLine(Iniciais(texto));

            Console.ReadKey();
        }

        static void UltimaLetra(string texto)
        {
            Console.WriteLine($"A ultima letra do seu texto é: {texto[texto.Length - 1]}");
        }

        static string TrocarCaracter(string txt, char inicial, char final)
        {
            return $"Você trocou '{inicial}' por '{final}' - {txt.Replace(inicial, final)}";
        }

        static string Iniciais(string texto)
        {
       
            if (texto.IndexOf(" ") != 0)
                return $"Iniciais - {texto.ToUpper()[0]}{texto.ToUpper()[texto.IndexOf(" ") + 1]}";
            else
                return $"Inicial - {texto.ToUpper()[0]}";   

        }
    }
}
