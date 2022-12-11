// Создание методов, использование массивов

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Заполнение массива числами от 1-9
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] array = new int[20];

FillArray(array);
PrintArray(array);

Console.WriteLine(string.Join("," , array)); // Вывод всего массива одной строкой

