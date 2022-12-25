// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] FillMatrix()
{
    int[,] Matrix1 = new int[4,4];
    int n = 1;
    int i = 0;
    int j = 0;
    
    while (n <= 16)
    {

        Matrix1[i, j] = n;
        n = n + 1;
        if (i <= j + 1 && i + j < 3)
        {
        j++;
        }
        else if (i < j && i + j >= 3)
        {
        i++;
        }
        else if (i >= j && i + j > 3)
        {
        j--;
        }
        else
        i--;
        
    }
    return Matrix1;
}

void PrintMatrix(int[,] Matrix)
{
    for(int i = 0; i < 4; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < 4; j++)
        {
            {
            Console.Write(Matrix[i, j] + " ");
            }
        }
    }
}

int[,] Matrix = FillMatrix();
PrintMatrix(Matrix);
