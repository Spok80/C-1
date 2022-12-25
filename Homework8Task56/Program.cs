// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SummaLine(int[,] matrix)
{
    int[] summaMas = new int[matrix.GetLength(0)];
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
    
         int summa = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i,j];
            
        }
        summaMas[i] = (summa);
    }

    return summaMas;    
}

void PrintMin(int[] SummaMatrix)
{
    int line = 0;
    int min = SummaMatrix[0];
    for (int i=0; i<SummaMatrix.Length; i++)
    {
        if (min > SummaMatrix[i])
        {
            min = SummaMatrix[i];
            line = i; 
        }
    }
    Console.WriteLine($"Минимальная сумма всех элементов в {line+1} - строке");
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
int[] SummaMatrix = SummaLine(matrix);

Console.WriteLine($"Сумма всех элементов строк - {string.Join("; ", SummaMatrix)}");
PrintMin(SummaMatrix);
}