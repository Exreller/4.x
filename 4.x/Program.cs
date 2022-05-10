using System;

namespace _4.x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Цикл for");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском, с маленькой буквы");
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
            while (k < 3)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском, с маленькой буквы");
                Console.WriteLine(k);

                var text = Console.ReadLine();

                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                switch (text)
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
                        continue;

                }

                k++;
            }

            Console.WriteLine("Цикл do while");
            int t = 0;
            do
            {
                Console.WriteLine("Напишите свой любимый цвет на английском, с маленькой буквы");
                Console.WriteLine(t);

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

                t++;
            }
            while (t < 3);

        }
		
    }
}
