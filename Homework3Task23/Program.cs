// Задача 23. Принимает на вход число N и выводит таблицу кубов от 1 до N.

//3 -> 1,8,27
//5 -> 1,8,27,64,125

Console.WriteLine("Введите число больше 0");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i=1; i<=N; i++)
{
Console.WriteLine($"Число {i} В кубе = {i*i*i}");
}
