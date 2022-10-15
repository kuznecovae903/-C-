// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] CreateMatrix (int row, int col, int min, int max) 
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}

Console.WriteLine("Для перемножения количество строк и столбцов в матрицах должна быть равно.");
Console.Write("Введите количество строк и столбцов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] array2DFirst = CreateMatrix(num, num, 0, 9);
Console.WriteLine("Первый массив:");
PrintMatrix(array2DFirst);
Console.WriteLine("Второй массив:");
int[,] array2DSecond= CreateMatrix(num, num, 0, 9);
PrintMatrix(array2DSecond);
Console.WriteLine("Массив - произведение элементов:");


int[,] resultMatrix = new int[num, num];
for (int i = 0; i < array2DFirst.GetLength(0); i++)
{
    for (int j = 0; j < array2DSecond.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < array2DFirst.GetLength(1); k++)
        {
            resultMatrix[i, j] += array2DFirst[i, k] * array2DSecond[k, j];
        }
    }
}

PrintMatrix(resultMatrix);