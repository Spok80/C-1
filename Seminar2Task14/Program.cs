// Задача 14. На вход принимает число и проверяет, кратно ли оно одновременно и 7 и 23
// 7 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ostatok1 = number % 7;
int ostatok2 = number % 23;

if (ostatok1 == 0 && ostatok2 == 0)
{
Console.WriteLine($"Число {number} кратно и 7 и 23");
}
else
{
Console.WriteLine($"Число {number} не кратно и 7 и 23");   
}
