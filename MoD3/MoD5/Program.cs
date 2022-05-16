using System;

class MainClass
{
    static void ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет с маленькой буквы: ");
        switch (Console.ReadLine())
        {
            case "красный":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Вы выбрали красный");
                break;
            case "зелёный":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Вы выбрали зелёный");
                break;
            case "голубой":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Вы выбрали голубой");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Цвет по умолчанию жёлтый");
                break;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Цикл for");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);

            Console.WriteLine("Напишите свой любимый цвет с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "красный":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали красный");
                    break;

                case "зелёный":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали зелёный");
                    break;
                case "голубой":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали голубой");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Цвет по умолчанию жёлтый");
                    break;
            }
        }

        Console.WriteLine("Цикл while");
        int k = 0;
        while (k < 3)
        {
            Console.WriteLine(k);

            Console.WriteLine("Напишите свой любимый цвет с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "красный":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали красный");
                    break;

                case "зелёный":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали зелёный");
                    break;
                case "голубой":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали голубой");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Цвет по умолчанию жёлтый");
                    break;
            }
        }

        Console.WriteLine("Цикл do");
        int t = 0;

        do
        {
            Console.WriteLine(t);

            Console.WriteLine("Напишите свой любимый цвет с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "красный":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали красный");
                    break;

                case "зелёный":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали зелёный");
                    break;
                case "голубой":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Вы выбрали голубой!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Цвет по умолчанию жёлтый!");
                    break;
            }

        } while (t < 3);

        Console.ReadKey();
    }
}