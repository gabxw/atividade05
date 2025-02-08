using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class exercicio05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero");
            var num2 = int.Parse(Console.ReadLine());

            var resultado = num1 > num2 ? "O primeiro núemro é maior" : "O  segundo número é maior";

            Console.WriteLine(resultado);
        }
    }
}