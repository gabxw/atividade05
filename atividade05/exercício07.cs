using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");

            bool sucesso = int.TryParse(Console.ReadLine(), out int num1);

            var resultado = sucesso
                ? $"O número escolhido foi {num1}."
                : "Nenhum número válido foi digitado.";

            Console.WriteLine(resultado);
        }
    }
}
