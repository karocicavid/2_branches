using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ages(out int age1, out int age2);
            Names(out string name1, out string name2);

            if (age1 > age2)
            {
                Console.Write($"{name1} старше {name2} на {age1 - age2} лет(года)");
            }

            if (age1 < age2)
            {
                Console.Write($"{name2} старше {name1} на {age2 - age1} лет(года)");
            }

            if (age1 == age2)
            {
                Console.Write($"{name2} и {name1} ровесники");
            }
        }

        static void Ages(out int age1, out int age2)
        {
            Console.Write("Введите возраст 1 -ого человека:");
            age1 = int.Parse(Console.ReadLine());
            Console.Write("Введите возраст 2 -ого человека:");
            age2 = int.Parse(Console.ReadLine());
        }
        static void Names(out string name1, out string name2)
        {
            Console.Write("Введите название 1 -ого человека:");
            name1 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите название 2 -ого человека:");
            name2 = Convert.ToString(Console.ReadLine());
        }

    }
}
