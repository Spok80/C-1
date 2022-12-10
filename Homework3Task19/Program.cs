// Задача 19. Принимает на вход пятизначное число и проверяет, является ли оно полиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10000 || number > 99999) 
{
Console.WriteLine($"Число {number} не является пятизначным, Введите пятизначное число");
number = Convert.ToInt32(Console.ReadLine());
}
int digite1 = number / 10000;
int digite2 = number / 1000 % 10;
int digite4 = number / 10 % 10;
int digite5 = number % 10;

if (digite1 == digite5 && digite2 == digite4)
{
Console.WriteLine($"Число {number} - является полиндромом");
}
else
{
Console.WriteLine($"Число {number} - не является полиндромом");   
}
