using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Как тебя зовут?: ");
        string MyName = Console.ReadLine();
        Console.WriteLine("Привет, " + MyName);
        Console.ReadKey();
    }
}
