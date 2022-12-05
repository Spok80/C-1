// Задача №5. На вход принимает число (N), а на выходе показывает все целые числа от -N до N.
// N=2 -> -2,-1,0,1,2

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = -N; i <= N; i++)
{
Console.Write(i  + " ");
}