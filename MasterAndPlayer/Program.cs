using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Master tell me a number between 0 and 100: ");
            string number = Console.ReadLine();
            int n = int.Parse(number);
            if (n < 100 && n > 0){
                for(int i = 0; i>100;i++){
                    Console.WriteLine("");
                }
                while (true){
                    Console.Write("Player choose a number between 0 and 100: ");
                    string number2 = Console.ReadLine();
                    int i = int.Parse(number);
                }
            }
            else{
                Console.WriteLine("Number not acceptable");
            }

        }
    }
}
