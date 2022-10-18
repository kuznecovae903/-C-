// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
//34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

/*
int[, ,] CreateMatrix3D (int row, int col, int dep, int min, int max) 
{
    int[, ,] matrix = new int[row, col, dep];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = rnd.Next(min, max +1);
            }
            
        }
    }
    return matrix;
} 

void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            //if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j, k], 1}|");
            //else Console.Write($"{matrix[i, j, k], 1}");
            
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                //if (k < matrix.GetLength(2) -1) Console.Write($"{matrix[i, j, k], 1}|");
                //else Console.Write($"{matrix[i, j, k], 1}");
            }
        }
        Console.WriteLine();        
    }        
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 2;
            }
        }
    }
}

int[, ,] array3D = CreateMatrix3D(3, 3, 3, 0, 9);
Console.WriteLine();
FillArray(array3D);
PrintMatrix(array3D);
*/
/*
int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int minNumber = 10;
int maxNumber = 99;
*/                                                                                                                      
int[,,] testArray = new int[2, 2, 2];

Console.WriteLine();
FillArrayRandomNumber(testArray, 10, 99);
PrintArrayWithIdex(testArray);

void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9)
{
 Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber + 1);
                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
               Console.Write($"{array[i, j, h]}({i},{j},{h}) ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}