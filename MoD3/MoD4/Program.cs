using System;

class MainClass
{
	public static void Main(string[] args)
	{
		(string Name, string Type, double Age, int NameCount) Pet;

		Console.Write("Введите имя вашего питомца: ");
		Pet.Name = Console.ReadLine();

		Console.Write("Что у вас за питомец: ");
		Pet.Type = Console.ReadLine();

		Console.Write("Возраст вашего питомца: ");
		Pet.Age = double.Parse(Console.ReadLine());

		Console.WriteLine("Имя питомца по буквам: ");
		foreach (var NameCount in Pet.Name)
		{
			Console.Write(NameCount + " ");
		}
		Pet.NameCount = Pet.Name.Length;
		Console.WriteLine();
		Console.WriteLine($"Ваше питомца зовут: {Pet.Name}");
		Console.WriteLine($"Ваш питомец это: {Pet.Type}");
		Console.WriteLine($"Возраст вашего питомца: {Pet.Age}");
		Console.WriteLine($"Количество букв в имени: {Pet.NameCount}");












		/*
		int[,] arr =
		{
			{ -5, 54, 21,-4},
			{ 23, -32, 12, 34 }
		};

		int sum = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				if (arr[i,j] > 0)
				{
					sum++;
				}
			}

        }

		Console.WriteLine("Кол-во положительных чисел: " + sum);

		\\ сумма положительных чисел в массиве
		foreach (int num in array)
		{
			if (num >= 0)
			{
				sum += num;
			}
		}
		Console.WriteLine(sum);

		\\ Разбор вводимого имени в массиве

		Console.WriteLine("Введите ваше имя: ");
		var name = Console.ReadLine();
		Console.WriteLine($"Ваше имя: {name}");
		for (var i = name.Length -1; i >= 0; i--)
		{
			Console.Write(name[i] + " ");

		}
		Console.WriteLine();
		Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
		*/
	}
}