using System;

namespace SmoothOperator
{
    class Program
    {
        /// <summary>
        /// Programa que pede número e mostra esse número
        /// incrementado e decrementado
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Insere um número inteiro não-negativo: ");
            string resposta = Console.ReadLine(); //recebe variável
            byte n = byte.Parse(resposta); //transforma variável string em byte

            Console.WriteLine($"{--n}\n{++n}\n{n/2}\n{n<<3}\n{n^5}\n{n>10}");
        }
    }
}
