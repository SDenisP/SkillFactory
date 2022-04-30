using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Как тебя зовут? \n ");
        Console.WriteLine();
        string MyName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("\t Приятно познакомиться " + MyName + ", меня зовут Денис");
        Console.WriteLine();
        Console.Write("Сколько тебе лет? \n ");
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

        Console.Write("У тебя есть домашний питомец? \n ");
        Console.WriteLine();
        string pet = Console.ReadLine();
        Console.WriteLine();

        switch (pet)
        {
            case ("Да"):
                Console.WriteLine("\t Поздравляю");
                Console.WriteLine();
                break;
            case ("Нет"):
                Console.WriteLine("\t Возможно он у тебя появится");
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("\t В следующий раз пиши первую букву БОЛЬШОЙ");
                Console.WriteLine();
                break;
        }
        Console.WriteLine("Какой у тебя размер ноги? \n ");
        Console.WriteLine();
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("\t У тебя {0}, а у меня 45 размер", size);
        Console.WriteLine();
        Console.WriteLine("Приятно было провести с тобой время {0}. \nДо встречи!", MyName);

        Console.ReadLine();
    }
}
