// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);

Console.WriteLine();
int FindRowsCount = ReadInt("Введите строку элемента") - 1;
int FindColumnsCount = ReadInt("Введите столбец элемента") - 1;

if (FindRowsCount < 0 || FindColumnsCount < 0 || FindRowsCount >= rowsCount || FindColumnsCount >= columnsCount)
{
    Console.Write($" Не существует {FindRowsCount+1} строки и/или {FindColumnsCount+1} столбца");
}
else
{
    Console.Write($" Элемент находящийся в {FindRowsCount+1} строке и {FindColumnsCount+1} столбце - {matrix[FindRowsCount, FindColumnsCount]}");
}
