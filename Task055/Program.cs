//Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для пользователя.

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
/* метод для транспонирования любой матрицы
int[,] TranspArray(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j= 0; j < matrix.GetLength(1); j++)
        {
            result [j,i] = matrix[i,j];
        }
    }
    return result;
}
*/

int[,] TranspArray(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j= 0; j < matrix.GetLength(1); j++)
        {
            result [j,i] = matrix[i,j];
        }
    }
    return result;
}
int[,] array2D = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
if (array2D.GetLength(0) == array2D.GetLength(1)) //if и else добавлены для проверки на квадратность матрицы
{                                                 // для любой матрицы - их надо убрать  
int[,] transpRes = TranspArray(array2D);
PrintMatrix(transpRes);
}
else Console.Write("Ваша матрица не квадратная ");
//второй метод решения
int[,] TranspArray(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j= 0; j < matrix.GetLength(1); j++)
        {
            result [j,i] = matrix[i,j];
        }
    }
    return result;
}

if (array2D.GetLength(0) == array2D.GetLength(1))
{

TransponArray2(array2D);
Console.WriteLine("-------------------------------------");
PrintMatrix(array2D);
}
else
{
Console.WriteLine("Массив не квадаратный!");
int[,] array2Dtranspot = TransponArray(array2D);
PrintMatrix(array2Dtranspot);
}