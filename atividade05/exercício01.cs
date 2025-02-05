using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class exercício01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");
            var num = int.Parse(Console.ReadLine());


            var resultado = num % 2 == 0 ? "O número é par" : "O numero é impar";

            Console.WriteLine(resultado);

        }
    }
}
