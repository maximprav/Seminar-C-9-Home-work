// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите натуральное число:");
int N = int.Parse(Console.ReadLine()!)!;
Console.Write($"N = {N} -> ");
for (int i = N; i >= 1; i--)
{
    Console.Write($"{NaturalNumber(i)} ");
}

int NaturalNumber(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else 
    {
        return n;
    }
}





