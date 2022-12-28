// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = 8;
int M = 1;

if (N < 1)
{
    Console.Write("Не корректно задано значение N");
    return;
}
int PrintN(int n, int m)
{
    
    if (m == n) return m;
    Console.Write(PrintN(n, m + 1));
    Console.Write(",");
    return m;
}
Console.Write(PrintN(N, M));
