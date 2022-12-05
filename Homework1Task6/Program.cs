// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 2;
if (a == 0)
{
  Console.Write("Число четное и равно " + number);
}
else
{
  Console.Write("Число нечетное и равно " + number);  
}