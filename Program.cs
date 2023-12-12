using System;

class Program
{
    static void Main() {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1. Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine("2. Задача 43: точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateSumOfPositiveNumbers();
                break; 
            case 2:
                FindIntersectionPoint();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }    }
    
    static void CalculateSumOfPositiveNumbers() {
    Console.WriteLine("Введите числа одной строкой, разделенные запятыми:");
    string input = Console.ReadLine();

    string[] numbers = input.Split(',');

    int positiveCount = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (int.TryParse(numbers[i], out int parsedNumber)&&parsedNumber > 0)
            {
                positiveCount++;
            }
    }
    Console.WriteLine($"Количество положительных чисел: {positiveCount}");}

static void FindIntersectionPoint(){

    Console.WriteLine("Введите значение b1:");
    double b1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите значение k1:");
    double k1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение b2:");
    double b2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение k2:");
    double k2 = double.Parse(Console.ReadLine());

    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны, нет точки пересечения.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"Точка пересечения: ({x}, {y})");
    }}

}
