// Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//1, 7 -> такого элемента в массиве нет

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


Console.WriteLine("Введите позиции элемента в массиве:");
Console.Write("- индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("- индекс колонки: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] array2D = CreateMatrixRndInt(5, 6, -100, 100);
PrintMatrix(array2D);
Console.WriteLine();
if (rows < array2D.GetLength(0) && columns < array2D.GetLength(1)) Console.WriteLine(array2D[rows, columns]);
else Console.WriteLine($"{rows}, {columns} -> позиции c указанными индексами в массиве нет");