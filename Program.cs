using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1. Определить максимальное из трех чисел");
        Console.WriteLine("2. Определить максимальное из двух чисел");
        Console.WriteLine("3. Проверить, является ли число четным");
        Console.WriteLine("4. Вывести все четные числа от 1 до N");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                MaxOfThreeNumbers();
                break;
            case 2:
                MaxOfTwoNumbers();
                break;
            case 3:
                CheckIfEven();
                break;
            case 4:
                PrintEvenNumbers();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void MaxOfThreeNumbers()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));

        Console.WriteLine($"Максимальное число: {max}");
    }

    static void MaxOfTwoNumbers()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Max: {((a>b)?a:b)}");

    }

    static void CheckIfEven()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число {((num % 2 != 0)?"не":"")}четное.");
    }

    static void PrintEvenNumbers()
    {
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Четные числа от 1 до N:");

        for (int i = 2; i <= N; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
