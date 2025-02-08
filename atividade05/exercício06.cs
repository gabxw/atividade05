using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Exercicio06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            float num1 = float.Parse(Console.ReadLine());

            float valorAbs = Math.Abs(num1);

            Console.WriteLine(valorAbs);
        }
    }
}