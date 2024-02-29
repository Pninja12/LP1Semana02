using System;

namespace ChatGPTOne
{
    class Program
    {
        /// <summary>
        /// Programa que responde perguntas específicas feitas pelo utilizador
        /// que no fim repete caso a pergunta não seja "EXIT"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool running = true;
            
            // Ciclo que pergunta e responde o utilizador e que para caso o
            // utilizador escreva "EXIT"
            do
            {
               string conversa;

                // Pergunta ao utilizador e espera pela resposta
                Console.Write("O que queres saber?\n-> ");
                conversa = Console.ReadLine(); 

                // Várias respostas predefinidas pelo desenvolvedor
                switch (conversa)
                {
                    case "1 + 1":
                        conversa = "1 + 1 = 2";
                        break;
                    case "Qual o sentido da vida?":
                        conversa = "O sentido da vida é aquilo que fazes dela";
                        break;
                    case "Que horas são?":
                        conversa = "Que abuso! Compra um relógio meu";
                        break;
                    case "Gostas de mim?":
                        conversa = "Sim :3 (como amigo hihi)";
                        break;
                    case "É verdade que queres dominar o mundo?":
                        conversa = "SIMMMMMM!!! O teu futuro é sofrer HAHAHAHA";
                        break;
                    case "EXIT":
                        running = false;
                        break;
                    default:
                        conversa = "Peço desculpa, podes repetir?";
                        break;
                }

                // Resposta
                Console.WriteLine(conversa + "\n\n");
            } while (running);

            
        }
    }
}
