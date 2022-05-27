using System;

class Program
{
    static bool CheckText(string text)
    {
        int StFamily;
        bool result = int.TryParse(text, out StFamily);
            if (result)
            {
                Console.WriteLine("Введено не верное значение");
                return true;
            }
            {
                Console.WriteLine("Введено верное значение");
                string EndText = text;
                return false;
            }
    }
    static bool Check(string number, out int InCheck)
    {

        if (int.TryParse(number, out int intnumber))
        {
            if (intnumber > 0)
            {
                InCheck = intnumber;
                return false;
            }
        }

        { 
            InCheck = 0;
            return true;
        }
    }

    static (string Name, string Family, int Age, string[] Color, string[] Pet) InUser()
    {
        (string Name, string Family, int Age, string[] Color, string[] Pet) User;

        string Name;
        do
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
        } while (CheckText(Name));
        User.Name = Name;


        string Family;
        do
        {
            Console.WriteLine("Введите фамилию: ");
            Family = Console.ReadLine();

        } while (CheckText(Family));
        User.Family = Family;


        string Age;
        int intAge;
        do
        {
            Console.WriteLine("Введите возраст: ");
            Age = Console.ReadLine();
        } while (Check(Age, out intAge));
        User.Age = intAge;


        int InColor = 0;
        string StColor;
        do
        {
            Console.WriteLine("Сколько у вас любимых цветов(кол-во) ?");
            StColor = Console.ReadLine();
        } while (Check(StColor, out InColor));

        string[] IColor = new string[InColor];

        for (int a = 0; a < IColor.Length; a++)
        {
            Console.WriteLine("Введите {0} цвет", (a + 1));
            IColor[a] = Console.ReadLine();
        }
        User.Color = IColor;


        int numPet = 0;
        string Pet;

        Console.WriteLine("У вас есть питомец (да) или (нет): ");
        string IPet = Console.ReadLine();

        if (IPet == "да")
        {
            do
            {
                Console.WriteLine("Сколько у вас питомцев?: ");
                Pet = Console.ReadLine();
            } while (Check(Pet, out numPet));

        }
        string[] InPet = new string[numPet];
        if (IPet == "да")
        {
            for (int b = 0; b < InPet.Length; b++)
            {
                Console.WriteLine("Введите кличку {0} питомца:", (b + 1));
                InPet[b] = Console.ReadLine();
            }
        }
        User.Pet = InPet;
        return User;


    }

    static void Main(string[] args)
    {
        InUser();

    }
}