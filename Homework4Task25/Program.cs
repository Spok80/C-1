// Задача 25. Принимает 2 числа и возводит одно число в степень другого

// 3,5 -> 243
// 2,4 -> 16

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1;
int i = 1;
for (i=1; i != number2; i++)
{
    result = result * number1;
}
Console.WriteLine($"Число {number1} в степени {number2} равное {result}");