using System;

class MainClass
{
    //static string GetDataFromConsole() => Console.ReadLine();
    static string ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет с маленькой буквы: ");
        string color = Console.ReadLine();
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
        return color;
    }
    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        // сортировка одномерного массива
        int number;
        for (int a = 0; a < result.Length; a++)
        {
            for (int b = a + 1; b < result.Length; b++)
            {
                if (result[a] > result[b])
                {
                    number = result[a];
                    result[a] = result[b];
                    result[b] = number;
                }
            }
        }

        foreach(var Newnumber in result)
        {
            Console.WriteLine(Newnumber + " ");
        }
        return result;
    }
    public static void Main(string[] args)
    {

        GetArrayFromConsole();

















        /*
        var favcolors = new string[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor();
        }

        Console.WriteLine("Выши любимые цвета: ");

        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
        Console.ReadKey();
        */
    }
}