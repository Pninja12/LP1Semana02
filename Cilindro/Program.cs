using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a altura do cilindro: ");
            string resposta = Console.ReadLine(); //recebe variável
            float altura = float.Parse(resposta); //transforma variável 
                                                  //string em float
            Console.Write("Qual o raio do cilindro: ");
            resposta = Console.ReadLine(); //recebe variável
            float raio = float.Parse(resposta); //transforma variável 
                                                //string em float

            Console.Write("O volume do cilindro é: ");
            Console.WriteLine($"{MathF.PI * Math.Pow(raio, 2) * altura}");
        }
    }
}
