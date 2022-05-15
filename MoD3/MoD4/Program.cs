using System;

class MainClass
{
	public static void Main(string[] args)
	{

		(string Name, string Family, string Login,
		int VoidLogin, bool IPet, double AgeUser, string[] threeColor) User;

		Console.WriteLine("\nКакое кол-во пользователей обрабатывать?: ");
		int quantity = int.Parse(Console.ReadLine());

		for (int j = 1; j <= quantity; j++)
		{
			Console.WriteLine($"\nПользователь: {j}");

			Console.WriteLine("\nВведите имя: ");
			User.Name = Console.ReadLine();

			Console.WriteLine("\nВведите фамилию: ");
			User.Family = Console.ReadLine();

			Console.WriteLine("\nВведите логин");
			User.Login = Console.ReadLine();

			User.VoidLogin = 0;

			for (int a = 1; a <= User.Login.Length; a++)
			{
				User.VoidLogin = a;
			}

			Console.WriteLine($"\nДлинна логина: {User.VoidLogin}");

			Console.WriteLine("\nУ вас есть животное?: ");
			string Pet = Console.ReadLine();

			if (Pet == "Да")
			{
				User.IPet = true;
			}
			else if (Pet == "Нет")
			{
				User.IPet = false;
			}

			Console.WriteLine("\nВведите возрас пользователя: ");
			User.AgeUser = double.Parse(Console.ReadLine());

			User.threeColor = new string[3];
			Console.WriteLine("\nВведите три любимых цвета пользователя: ");
			for (int i = 0; i < User.threeColor.Length; i++)
			{
				User.threeColor[i] = Console.ReadLine();
			}
			
		}













		/*
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


		int[] brav = new int[] { 27, 28, 43, 7, 4 };
		
		string[] abrams = new string[4];

		abrams[0] = "Ире";
		abrams[1] = "Егору";
		abrams[2] = "Денису";
		abrams[3] = "Мише";

		Console.WriteLine($"{abrams[1]} {brav[3]} лет");
		Console.WriteLine($"{abrams[0]} {brav[1]} лет");
		Console.WriteLine($"{abrams[2]} {brav[0]} лет");
		Console.WriteLine($"{abrams[3]} {brav[4]} лет");


		// Сумма положительных чисел в двумерном массиве.
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

		// сумма положительных чисел в массиве
		foreach (int num in arr)
		{
			if (num >= 0)
			{
				sum += num;
			}
		}
		Console.WriteLine(sum);

		// Разбор вводимого имени в массиве

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