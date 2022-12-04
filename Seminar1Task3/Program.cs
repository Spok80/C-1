// Вывести день недели по заданному номеру

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 7) | (number < 1))
{
Console.WriteLine("Ошибка, введено число не от 1 до 7");
}
else
if (number == 1)
{
Console.WriteLine ("Понедельник");   
}
else
if (number == 2)
{
 Console.WriteLine ("Вторник");   
}
else
if (number == 3)
{
 Console.WriteLine ("Среда");   
}
else
if (number == 4)
{
 Console.WriteLine ("Четверг");   
}
else
if (number == 5)
{
Console.WriteLine ("Пятница");   
}
else
if (number == 6)
{
Console.WriteLine ("Суббота");  
}
else
{
Console.WriteLine ("Воскресенье");
}
