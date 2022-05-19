using System;

class MainClass
{
    static void ShowArray(int[] massiv, bool logik = false)
    {
        var temp = massiv;
        int[] result = new int[] { 12, 34, 45, 1, 6, 7, 23 };
        if(logik)
        {
            temp = SortArray(massiv);
        }
        foreach(var exit in temp)
        {
            Console.WriteLine(exit + " ");
        }
    }
    static void ShowColor(string username, params string[] favcolors)
    {

        Console.WriteLine("Ваши любимые цвета:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }

    }
    static int[] GetArrayFromConsole(int num = 3)
    {
        var result = new int[num];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    static int[] SortArray(int[] result)
    {
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
        return result;
    }
    public static void Main(string[] args)
    {

        var array = GetArrayFromConsole(10);
        ShowArray(array, true);












        /*
        var favcolors = new string[3];
      
        for (int i = 0; i < favcolors.Length; i++)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            favcolors[i] = Console.ReadLine();
       
            switch (favcolors[i])
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

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
       // }
       //
        ShowColor(favcolors[0], favcolors[2]);
        

   














        
        var (name, age) = ("Евгения", 27);
        Console.WriteLine("Моё имя {0}", name);
        Console.WriteLine("Мой возраст {0}", age);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.WriteLine("Введите возраст цифрами: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше имя {0}", name);
        Console.WriteLine("Ваш возраст {0}", age);

        var favcolors = new string[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor(name,age);
        }

        Console.WriteLine("Ваши любимые цвета:");

        foreach(var color in favcolors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine();












        string favcolors = new string[3];

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