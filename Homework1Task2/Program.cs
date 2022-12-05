// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
Console.Write("Числа равны и = ");   
Console.WriteLine(number1);
}
else
if (number1 > number2)
{
Console.Write("Число один больше числа два и = ");   
Console.WriteLine(number1);
}
else
{
Console.Write("Число два больше числа один и = ");   
Console.WriteLine(number2);   
}