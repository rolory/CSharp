using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1. принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.WriteLine("2. принимает на вход число и выдаёт сумму цифр в числе");
        Console.WriteLine("3. задаёт массив из 8 элементов и выводит их на экран");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                APowB();
                break;
            case 2:
                DigitSum();
                break;
            case 3:
                ArrayEight();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }
    static void APowB()
    {
        Console.WriteLine("Введите число A:");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите степень B:");
        int B = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(A, B);
        Console.WriteLine($"{A}^{B} = {result}");
    }
    static void DigitSum()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        Console.WriteLine($"Сумма цифр в числе: {sum}");
    }
    static void ArrayEight()
    {
       int[] arr = new int[8];
       Random random = new Random();

        for (int i = 0; i < 8; i++)
        {
            arr[i] = random.Next(1, 100); // Генерация случайного числа от 1 до 99
        }

        Console.WriteLine("Массив:");
        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }
}
