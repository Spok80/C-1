// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
max = number2;    
}
if (number3 > max)
{
max = number3;
}
Console.WriteLine("max = " + max);