using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1. 25: принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
        Console.WriteLine("2. 27: принимает на вход число и выдаёт сумму цифр в числе");
        Console.WriteLine("3. 29: задаёт массив из 8 элементов и выводит их на экран");
        Console.WriteLine("4. 34: Подсчет четных чисел в массиве");
        Console.WriteLine("5. 36: Сумма элементов на нечетных позициях");
        Console.WriteLine("6. 38: Разница между максимальным и минимальным элементами");

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
            case 4:
                EventCount();
                break;
            case 5:
                UnevenSum();
                break;
            case 6:
                MaxMinDifference();
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

    static void EventCount()
    {
        int[] array = new int[4];

        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        Console.WriteLine("Массив:");
        Console.WriteLine("[" + string.Join(", ", array) + "]");
        int evenCount = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

    }
    static void UnevenSum()
    {
        int[] array = new int[4];

        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            array[i] = random.Next(-100, 100);
        }

        Console.WriteLine("Массив:");
        Console.WriteLine("[" + string.Join(", ", array) + "]");

        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
    }
    static void MaxMinDifference()
    {
        int arrayLength = 5;
        double[] array = new double[arrayLength];

        Random random = new Random();
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = random.NextDouble() * 100;
        }

        Console.WriteLine("Массив:");

        foreach (double number in array)
        {
            Console.Write(number + " ");
        }

        double min = array[0];
        double max = array[0];

        foreach (double number in array)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        double difference = max - min;

        Console.WriteLine($"\nРазница между максимальным и минимальным элементами: {difference}");

    }
}
