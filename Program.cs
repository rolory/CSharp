using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задачу:");
        Console.WriteLine("1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        Console.WriteLine("2. принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ThirdDigit();
                break;
            case 2:
                WeekEnd();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }
    static void ThirdDigit()
    {        
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
        string numStr = num.ToString();

        if (numStr.Length >= 3)
        {
            char thirdChar = numStr[2];
            Console.WriteLine(thirdChar);
        } else {
            Console.WriteLine("Третьей цифры нет.");
        }} else {
            Console.WriteLine("Не число.");
        }

    }

    static void WeekEnd() {
 
        Console.Write("Введите день недели: ");
        if (int.TryParse(Console.ReadLine(), out int weekDay))
        {
            if (weekDay<1||weekDay>7) {
             Console.WriteLine("Не день недели.");
           } else {
            if (weekDay>5) {
             Console.WriteLine("да");
            } else {
             Console.WriteLine("нет");
            }

           }
        } else {
            Console.WriteLine("не число");
        }
    }
}
