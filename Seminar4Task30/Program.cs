// Задача 30. Заполнить массив из 8 элементов нулями и единицами. Вывести на экран.

int [] array = new int[8]; // Массив array из 8 элементов целых чисел
for (int i = 0; i < 8; i++)
{
   array[i] = new Random().Next(0,2);
}
Console.WriteLine(string.Join("," , array));
