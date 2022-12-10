// Задача 27. Принимает число и выводит сумму цифр в числе

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int i = 1;
int result = 0;
int digite = 0;
for (i=1; number != 0; i++)
{
digite = number % 10;
number = number / 10;
result = result + digite;
}
Console.WriteLine($"Сумма цифр числа {number1} - {result}");