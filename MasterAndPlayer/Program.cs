using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Master insert number: ");
            string number = Console.ReadLine();
            int n = int.Parse(number);
            if (n < 100 && n > 0){
                for(int i = 0; i<100;i++){
                    Console.WriteLine(" ");
                }
                while (true){
                    Console.Write("Player insert number: ");
                    string number2 = Console.ReadLine();
                    int i = int.Parse(number2);
                    if (i > 100 || i < 0)
                    {
                        Console.WriteLine("Invalid number! Try again!");
                    }
                    else if (i < n){
                        Console.Write("The correct number is higher than ");
                        Console.WriteLine($"{i}.");
                    }
                    else if (i > n){
                        Console.Write("The correct number is lower than ");
                        Console.WriteLine($"{i}.");
                    }
                    else{
                        Console.Write("Player wins!");
                        break;
                    }
                }
            }
            else{
                Console.WriteLine("Invalid number!");
            }

        }
    }
}
