using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Как тебя зовут? \n");
        Console.WriteLine();
        string MyName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("\tПриятно познакомиться " + MyName + ", меня зовут Денис");
        Console.WriteLine();
        Console.Write("Сколько тебе лет? \n");
        Console.WriteLine();
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 18)
        {
            Console.WriteLine("\tДа ты уже взрослый(-ая)");
            Console.WriteLine();
        }
        else if (year < 18)
        {
            Console.WriteLine("\tДа ты еще маленький(-ая)");
            Console.WriteLine();
        }

        Console.Write("У тебя есть домашний питомец? \n");
        Console.WriteLine();
        string pet = Console.ReadLine();
        Console.WriteLine();

        switch (pet)
        {
            case ("Да"):
                Console.WriteLine("\tПоздравляю");
                Console.WriteLine();
                break;
            case ("Нет"):
                Console.WriteLine("\tВозможно он у тебя появится");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("\tВ следующий раз пиши первую букву БОЛЬШОЙ");
                Console.WriteLine();
                break;
        }
        Console.WriteLine("Какой у тебя размер ноги? \n");
        Console.WriteLine();
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("\tУ тебя {0}, а у меня 45 размер", size);
        Console.WriteLine();
        Console.WriteLine("Приятно было провести с тобой время {0}. \nДо встречи!", MyName);

        Console.ReadLine(); 
    }
    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
