﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Exercicio03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma letra");

            string lista = Console.ReadLine();
            int[] ints = new int[lista.Length];

            var resultado = ints.Length == 0 ? "A lista está vazia" : "A lista não está vazia";

            Console.WriteLine(resultado);
        }
    }
}
