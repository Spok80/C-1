// Задача 15. Ввод числа обозначающее день недели и вывод является ли этот день выходным или нет

Console.WriteLine("Введите число обозначающее день недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 1 || number > 7) 
{
Console.WriteLine($"Число {number} не является днем недели, Введите число от 1 до 7");
number = Convert.ToInt32(Console.ReadLine());
}
if (number == 6 || number ==7)
{
Console.WriteLine($"День недели {number} - выходной");
}
else
{
Console.WriteLine($"День недели {number} - рабочий день");   
}