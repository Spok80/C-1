// Задача 10. Принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 100 || number >= 1000) 
{
Console.WriteLine($"Число {number} не трехзначное, Введите число");
number = Convert.ToInt32(Console.ReadLine());
}
int digit2 = number / 10 % 10;
Console.WriteLine($"Цифра {digit2} - вторая цифра числа {number}");