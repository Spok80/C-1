// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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
    Console.WriteLine();
}

int[,] multi(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {

    
    for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            
            matrix3[i, j] = matrix1[i, j]*matrix2[i, j];
                    
        }
        
    }

       return matrix3;    
}

int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
if (rowsCount < 2 || columnsCount < 2)
{
    Console.WriteLine("Число строк и столбцов должно быть больше 1"); // Проверка на ввод параметра матрицы
}
else
{
int[,] matrix1 = GetRandomMatrix(rowsCount, columnsCount);
int[,] matrix2 = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix1);
PrintMatrix(matrix2);

int[,] matrix = multi(matrix1, matrix2);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц");
PrintMatrix(matrix);

}