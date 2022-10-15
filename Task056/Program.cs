// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int[] SumString(int[,] matrix)
{
    int[] resultSum = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultSum[i] += matrix[i,j];
        }
    }
    return resultSum;
}

void IndexStringMinSum(int[,] matrix)
{
    int[] sumString = SumString(matrix);
    int minSumString = sumString[0];
    int indexMinSum = 0;
    for (int i = 0; i < sumString.GetLength(0); i++)
    {
        if (sumString[i] <= minSumString)
        {
            indexMinSum = i;
            minSumString = sumString[i];
        }       
            
    }
    Console.Write($"Строка {indexMinSum + 1} имеет минимальную сумму элементов, равную {minSumString}. ");
}            

   
Console.Write("Введите количество строк и столбцов в квадратном массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrix(num, num, 0, 9);
Console.WriteLine();
PrintMatrix(array2D);
Console.WriteLine();
IndexStringMinSum(array2D);
