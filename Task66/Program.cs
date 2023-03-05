// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите меньшее число M:");
int m = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите большее число N:");
int n = int.Parse(Console.ReadLine()!)!;
Console.Write($"M = {m}; N = {n} -> ");
SumMtoN(m, n);

int SumNumbers(int m, int n)
{
    int sum = m;
    if (m == n)
        {
            return 0;
        }
    else
    {
        m++;
        sum = m + SumNumbers(m, n);
        return sum;
    }
}

void SumMtoN(int m, int n)
{
    Console.Write(SumNumbers(m - 1, n));
}





