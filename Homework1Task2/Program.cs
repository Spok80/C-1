// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
Console.Write("max = min = " + number1);   
}
else
if (number1 > number2)
{
Console.WriteLine("max = " + number1);   
Console.WriteLine("min = " + number2);
}
else
{
Console.WriteLine("max = " + number2);   
Console.WriteLine("min = " + number1);
}