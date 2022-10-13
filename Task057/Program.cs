// Задача 57: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных.

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

int[] GetArrayFromMatrix(int[,] matrix)
{
    int[] result = new int[matrix.Length]; //эта функция определяет количество элементов массива 2D

    int index = 0;// это счетчик
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j];
            index++;
        }
    }
    return result;
}

void CountPrintArrayGlossary(int[] localarray) //метод считает сколько раз повторяется число в одномер.массиве
{
    int num = localarray[0]; //берем первый элемент
    int count = 1; //задаем счетчик = 1 элементу
    for (int i = 1; i < localarray.Length; i++) //здесь со второго элемента массива
    {
        if (num == localarray[i]) //условие равенства первого какому нибудь еще элементу
        {
            count++; //счетчик +1
        }
        else
        {
            Console.WriteLine($"{num} повторяется {count} раз;");// посчитали первое число
            num = localarray[i];//присвоили num следующее значение
            count = 1;//счетчик опять =1           
        }
    }
Console.WriteLine($"{num} повторяется {count} раз.");// посчитали последнюю цифру
}

int[,] array2D = CreateMatrixRndInt(3, 3, 0, 10);
int[] array = GetArrayFromMatrix(array2D);
PrintMatrix(array2D);
Array.Sort(array); //это функция сортировки массива уже одномерного
Console.WriteLine();
CountPrintArrayGlossary(array);
