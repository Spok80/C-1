// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] FindSred(int[,] matrix)
{
    double[] summaMas = new double[matrix.GetLength(1)];
    
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
    
        double summa = 0;
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa = summa + matrix[i,j];
            
        }
        summaMas[j] = Math.Round(summa / matrix.GetLength(0),1);
    }

    return summaMas;    
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
double[] Sred = FindSred(matrix);

Console.WriteLine($"Среднее арифмитическое каждого столбца - {string.Join("; ", Sred)}");
}
