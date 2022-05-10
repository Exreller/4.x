using System;

namespace _4.x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл for");
            Console.WriteLine("Напишите свой любимый цвет на английском, с маленькой буквы");
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine(i);                
                switch (Console.ReadLine())
                {

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;


                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is Yellow!");
                        break;
                }

            }
            Console.WriteLine("Цикл while");
            int k = 0;
            Console.WriteLine("Напишите свой любимый цвет на английском, с маленькой буквы");

            while (k < 3)
            {                
                Console.WriteLine(k);          

                switch (Console.ReadLine())
                {
                    
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;


                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is Yellow!");
                        break;

                }

                k++;
            }
                   
        }
		
    }
}
