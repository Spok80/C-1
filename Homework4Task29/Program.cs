// Задача 29. Задать массив из 8 элементов и вывести его на экран. Данные вводятся пользователем.

int [] array = new int [8]; // Массив array из 8 элементов целых чисел
int number = 0;
for (int i = 0; i < 8; i++)
{
  Console.WriteLine("Введите число");
  number = Convert.ToInt32(Console.ReadLine());
  array[i] = number;
}
Console.WriteLine(string.Join("," , array));
