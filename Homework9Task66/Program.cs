// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int min = 1;
int max = 15;
int sum = 0;

if (max < min || max < 0 || min < 0)
{
    Console.Write("Не корректно заданы значения M и N");
    return;
}
int Summa(int m, int n)
{
    
    if (n == m) return sum + m;
    return sum + n + (Summa(m, n - 1));;
}
Console.Write(Summa(min, max));

