using System;

class MainClass
{
	public static void Main(string[] args)
	{

		int sum = 0;
		while (true)
		{
			Console.WriteLine("Введите число");
			int ti = int.Parse(Console.ReadLine());

			if (ti < 0)
			{
				continue;
			}

			else if (ti == 0)
			{
				break;
			}

			sum += ti;
			Console.WriteLine("Итоговая сумма {0}", sum);

		/*
			 Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

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
					Console.WriteLine("Твой любимый цвет красный!");
					break;

				case "cyan":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;
					Console.WriteLine("Твой любимый цвет бирюзовый");
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;
					Console.WriteLine("Твой любимый цвет зеленый!");
					break;

				case "gray":
					Console.BackgroundColor = ConsoleColor.Gray;
					Console.ForegroundColor = ConsoleColor.DarkGray;
					Console.WriteLine("Твой любимый цвет серый!");
					break;

				default:
					continue;
			}



			g++;
		*/
		}
	}
}