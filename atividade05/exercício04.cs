using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Exercicio04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma letra");

            string texto = Console.ReadLine();

            var resultado = string.IsNullOrEmpty(texto) ? "A String está vazia" : "A String não está vazia";

            Console.WriteLine(resultado);
        }
    }
}

