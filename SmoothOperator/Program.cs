using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um número inteiro não-negativo: ");
            string resposta = Console.ReadLine();
            byte n = byte.Parse(resposta);

            Console.WriteLine($"{--n}\n{++n}");
        }
    }
}
