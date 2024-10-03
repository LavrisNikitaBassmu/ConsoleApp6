using System;

class SwapVariables
{
    static void Main(string[] args)
    {
        // Инициализируем переменные
        int a = 5;
        int b = 10;

        Console.WriteLine("До обмена:");
        Console.WriteLine($"a = {a}, b = {b}");

        // Обменяем значения переменных
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("После обмена:");
        Console.WriteLine($"a = {a}, b = {b}");
    }
}