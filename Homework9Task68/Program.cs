// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int M = 2;
int N = 3;

if (M < 0 || N < 0)
{
    Console.Write("Не корректно заданы значения M и N");
    return;
}
int Akkerman(int M, int N)
{
    
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Akkerman(M - 1, 1);
    if (M > 0 && N > 0) return Akkerman(M - 1, Akkerman(M, N - 1));
    return N;
}
Console.Write($"A({M},{N}) = ");
Console.Write(Akkerman(M, N));
