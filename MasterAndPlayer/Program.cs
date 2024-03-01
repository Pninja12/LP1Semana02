using System;

namespace MasterAndPlayer
{
    class Program
    {
        /// <summary>
        /// Jogo entre dois utilizadores onde o primeiro diz o número que o
        /// segundo tenta adivinhar e o segundo recebe dicas sobre o número que
        /// está a tentar adivinhar
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Primeiro utilizador introduz número
            Console.Write("Number Master insert number: ");
            string number = Console.ReadLine();
            int n = int.Parse(number);

            //Verifica se número é válido ou não
            if (n < 100 && n > 0){

                //Loop de 100 linhas para "esconder"
                // a mensagem do número original
                for(int i = 0; i<100;i++){
                    Console.WriteLine(" ");
                }

                //Ciclo do jogo que acaba quando o jogador ganha
                while (true){

                    //Segundo utilizador introduz número
                    Console.Write("Player insert number: ");
                    string number2 = Console.ReadLine();
                    int i = int.Parse(number2);

                    //verifica se o número é válido ou não
                    if (i > 100 || i < 0)
                    {
                        Console.WriteLine("Invalid number! Try again!");
                    }
                    //verifica se o número é menor que a resposta
                    else if (i < n){
                        Console.Write("The correct number is higher than ");
                        Console.WriteLine($"{i}.");
                    }
                    //verifica se o número é menor que a resposta
                    else if (i > n){
                        Console.Write("The correct number is lower than ");
                        Console.WriteLine($"{i}.");
                    }
                    //se nada for ativado então o jogador ganhou e acaba o ciclo
                    else{
                        Console.Write("Player wins!");
                        break;
                    }
                }
            }
            //Se o número não for aceite então acaba o jogo com mensagem de erro
            else{
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
