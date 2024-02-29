using System;

namespace Cilindro
{
    class Program
    {
        /// <summary>
        /// Programa que pede por um raio e uma altura e devolve o volume e 
        /// a área de superfície de um cilindro 
        /// </summary>
        /// <param name="args"></param>
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
                                //PI * raio^2 * altura

            Console.Write("A área de superfície do cilindro é: ");
            Console.WriteLine($"{2 * MathF.PI * raio * (raio + altura)}");
                                //2 * PI * raio * (raio + altura)
        }
    }
}
