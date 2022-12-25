// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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


(int, int) FindMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    
        for(int i = 0; i < array.Length; i++)
     {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
     }
     return (max, min);
}

const int LENGTH = 10;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 1000;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int max, int min) = FindMaxMin(massive);
Console.WriteLine($"Разность максимального {max} и минимального числа массива {min} равна {max - min}");