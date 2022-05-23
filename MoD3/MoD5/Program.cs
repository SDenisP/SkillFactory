using System;
using System.Linq;

class MainClass
{

    static void ChangeAge(byte Age)     //Метод ввода возраста
    {
        Console.WriteLine("Введите возраст: ");
        byte AgeUser = byte.Parse(Console.ReadLine());
    }
    static void GetName(ref string name)    //Метод ввода имени
    {
        Console.WriteLine("Введите имя: ");
        name = Console.ReadLine();
    }
    static void ShowArray(int[] massiv, bool logik = false)     //Перебор массива
    {
        var temp = massiv;
        int[] result = new int[] { 12, 34, 45, 1, 6, 7, 23 };
        if (logik)
        {
            temp = SortArray(massiv);
        }
        foreach (var exit in temp)
        {
            Console.WriteLine(exit + " ");
        }
    }
    static int[] GetArrayFromConsole(ref int num)       // Указываем размерность массива
    {
        var result = new int[num];
        num = 6;
        return result;
    }
    static int[] SortArray(int[] result)        //Сортировка массива
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
    static void BigDataOperation(int[] arr, ref int data)      // Замена элемета массива числом
    {
        data = 4;
        arr[0] = data;
    }
    static void Echo(string zvon1, int glub1)       // Рекурсивный метод "Эхо"
    {
        var modif = zvon1;

        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        Console.BackgroundColor = (ConsoleColor)glub1;
        Console.WriteLine("..." + modif);

        if (glub1 > 1)
        {
            Echo(modif, glub1 - 1);
        }
    }   
    static decimal Factorial(decimal x)     //Вычисление факториала
    {
        if (x == 0)
        {
            return 1;
        }

        else
        {
            return x * Factorial(x - 1);
        }
    }
    private static int PowerUp(int N, byte pow)   // Возведение в степень
    {
        if (N == 0 || pow == 0)
        {
            return 1;
        }

        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }  
    public static void Main(string[] args)
    {

        Console.WriteLine("Введите число: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите степень: ");
        byte b = byte.Parse(Console.ReadLine());
        Console.WriteLine(PowerUp(a, b));






        Console.WriteLine("Введите число для расчёта факториала: ");
        decimal torial = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(torial));






        Console.WriteLine("Ты меня слышишь?");
        var zvon = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        int glub = int.Parse(Console.ReadLine());

        Echo(zvon, glub);

      
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
        }
       
        ShowColor(favcolors[0], favcolors[2]);
        
        /////////////////////////////////////////////////////////
        
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

        //////////////////////////////////////////////////////

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