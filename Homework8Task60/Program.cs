// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


int[,,] FillMatrix()
{
    int[,,] Matrix3d = new int[2,2,2];
    int n = 10;
    var rand = new Random();
    for(int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {

            Matrix3d[i, j, k] = n;
            n = n + 5;
            }
        }
    }

    return Matrix3d;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < 2; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
            Console.Write($" {matrix[i, j, k]} [{i},{j},{k}] ");
            }
        }
    }
    Console.WriteLine();
}

int[,,] matrix = FillMatrix();
PrintMatrix(matrix);
