// Нахожжение корня числа и возведения числа в степень

int a = 3;
int b = 3;

double resSqrt = Math.Sqrt(a); // Вычисление корня числа a
double resPow = Math.Pow(a,b); // Возведение в степень b числа a

resSqrt = (int)(resSqrt); // Выводит целую часть числа БЕЗ ОКРУГЛЕНИЯ

Console.WriteLine($"{resSqrt:f2}"); // Вывод числа с 2 знаками после запятой
Console.WriteLine($"{resPow}");

