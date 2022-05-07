using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		var color = Console.ReadLine();

			if (color == "red")
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
			}
     
			else if (color == "cyan")
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;
			}

			else if (color == "green")
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("Your color is cyan!");
			}

			Console.WriteLine();
			Console.WriteLine("Введите название вашего любимого цвета с маленькой буквы");

			switch(Console.ReadLine())
			{
				case "red":
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;
				break;

				case "cyan":
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;
				break;

				case "green":
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;
				break;

				case "gray":
				Console.BackgroundColor = ConsoleColor.Gray;
				Console.ForegroundColor = ConsoleColor.DarkGray;
				break;

				default:
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Red;
				break;

			}
		
	}
}