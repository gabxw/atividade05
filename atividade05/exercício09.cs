using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Exercicio09
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            float num2 = float.Parse(Console.ReadLine());


            var resultado = (num1 % num2 == 0) ?
                $"O número {num1} é divisível por {num2}."
              : $"O número {num1} não é divisível por {num2}.";

            Console.WriteLine(resultado);
        }
    }
}
