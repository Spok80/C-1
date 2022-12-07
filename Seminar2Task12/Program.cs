// Принимает на вход 2 числа и выводит, является ли второе кратное первому.
// Если число 2 не кратное первому, то вывести остаток

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

int chastnoe = number1 % number2;
if (chastnoe == 0)
{
Console.WriteLine("Второе число кратное первому");
}
else
{
Console.WriteLine($"Второе число не кратное первому, остаток = {chastnoe}");    
}

