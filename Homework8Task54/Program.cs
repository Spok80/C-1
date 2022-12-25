// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

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

int[,] increase(int[,] matrix)
{
    
    int temp = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
    
         
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
            if (matrix[i, j] > matrix[i, j+1])
            {
                temp = matrix[i, j+1];
                matrix[i, j+1] = matrix[i, j];
                matrix[i, j] = temp;
            }
            }          
        }
        
    }

    return matrix;    
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
if (rowsCount < 2 || columnsCount < 2)
{
    Console.WriteLine("Число строк и столбцов должно быть больше 1"); // Проверка на ввод параметра матрицы
}
else
{
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);

Console.WriteLine();
int[,] result = increase(matrix);
PrintMatrix(result);

}
