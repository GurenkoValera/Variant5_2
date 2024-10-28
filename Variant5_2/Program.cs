using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число a:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число b (должно быть больше a):");
        int b = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что a < b
        if (a >= b)
        {
            Console.WriteLine("Ошибка: a должно быть меньше b.");
            return;
        }

        int sum = 0;

        // Суммируем нечетные числа в диапазоне [a, b]
        for (int i = a; i <= b; i++)
        {
            if (i % 2 != 0) // Проверяем, является ли число нечетным
            {
                sum += i;
            }
        }

        // Выводим результат
        Console.WriteLine($"Сумма нечетных чисел в диапазоне [{a}, {b}] равна: {sum}");
    }
}
