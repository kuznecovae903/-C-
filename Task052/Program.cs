// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Console.WriteLine("Hello, World!");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("введите количество строк массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(n, m, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();


PrintMatrix(array2D);
Console.WriteLine();
//AvarageArifmeticNumColumns(array2D);

for (int j = 0; j < array2D.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            avarage = (avarage + array2D[i, j]);
        }
        avarage = avarage / array2D.GetLength(0);
        Console.Write(avarage + "; ");
    }
  
/*
double AvarageArifmeticNumColumns(int[,] matrix) //не поняла почему не все 
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            avarage = (avarage + array2D[i, j]);
        }
        avarage = avarage / array2D.GetLength(0);
        return avarage;
        Console.Write(avarage + "; ");
    }
}
*/

/*

double[] res = avarageArifmeticNumColumns(array2D);
Console.WriteLine("Среднее арифмитическое столбцов: ");
PrintArray(res);
/*
for (int j = 0; j < array2D.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            avarage = (avarage + array2D[i, j]);
        }
        avarage = avarage / array2D.GetLength(0);
        return avarage
        Console.Write(avarage + "; ");
    }

Console.Write(avarage + "; ");

double[] avarageArifmeticNumColumns(int[,] matrix) //так и не поняла почему код возвращает не все значения
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] = Math.Round(result[i] / matrix.GetLength(0), 2);
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("|");
}
*/
/*
double[] averagColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] = Math.Round(result[i] / matrix.GetLength(0), 2);
    }
    return result;
}
*/