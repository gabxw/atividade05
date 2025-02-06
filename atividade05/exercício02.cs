using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Exercicio02


    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            var num2 = int.Parse(Console.ReadLine());

            var resultado = num1 > num2 ? "O primeiro número é maior" : "O segundo número é maior";

            Console.WriteLine(resultado);
        }
    }
}
