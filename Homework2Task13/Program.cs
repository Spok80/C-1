// Задача 13. Программа выводит 3 цифру заданного числа или сообщает, что ее нет.

Console.WriteLine("Введите число");
double number = Convert.ToInt32(Console.ReadLine());
double ostatok = number / 10;
if (number < 99)
{
Console.WriteLine("Третьей цифры нет");   
}
else
{
while (ostatok >= 1)
{
 ostatok = ostatok / 10; 
}  
double digit3 = (int)((ostatok * 1000) % 10);
Console.WriteLine($"Третья цифра - {digit3}");
}