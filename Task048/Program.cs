// Задача 48: Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Amn = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5


int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    //var rnd = new Random();
    //max = (rows + columns);
    //min == 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
                {
                    matrix[i, j] = i + j;
                }
        }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} | ");
            else Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine("]");
    }
}
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = (rows + columns);
int[,] array2D = CreateMatrixInt(rows, columns, min, max);

PrintMatrix(array2D);
