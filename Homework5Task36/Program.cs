// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

int FindSum(int[] array)
{
     int sum = 0;
     for(int i = 1; i < array.Length; i=i+2)
     {
            sum = sum + array[i]; // Находим сумму элементов стоящих на нечетных позициях
     }
        
     return sum;
}

const int LENGTH = 10;
const int LEFTRANGE = -99;
const int RIGHTRANGE = 99;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях - {FindSum(massive)}");
