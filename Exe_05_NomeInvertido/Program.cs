using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_05_NomeInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Insira um texto:");
            texto = Console.ReadLine();

            Console.WriteLine($"Texto Invertido - {TextoInvertido(texto)}");

            Console.ReadKey();
        }

        static string TextoInvertido(string texto)
        {
            string textoInvertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoInvertido += texto[i];
            }

            return textoInvertido;
        }
    }
}
