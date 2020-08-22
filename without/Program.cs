using System;

namespace дз_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа сравнивает возраст 2-ух людей.");
            Console.Write("Введите название 1-ого пользователя:");
            string user1 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите возраст 1-ого пользователя:");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Введите название 2-ого пользователя:");
            string user2 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите возраст 2-ого пользователя:");
            int age2 = int.Parse(Console.ReadLine());

            if (age2 < 0 || age1 < 0)
            {
                Console.Write($"Введите правильные данные!");
            }

            else if (age2 > age1)
            {
                Console.Write($"{user2} старше {user1} на {age2 - age1} лет(года).");
            }

            else if (age2 == age1)
            {
                Console.Write($"{user1} и {user2} ровесники.");
            }

            else if (age1 > age2)
            {
                Console.Write($"{user1} старше {user2} на {age1 - age2} лет(года).");
            }

        }
    }
}

