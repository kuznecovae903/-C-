// Задача 29: Напишите программу, которая 
//задаёт массив из 8 элементов и 
//выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


//int[] array = new int[8] {1,2,5,7,19,6,1,33};
int[] array = new int[8];
FillArreRandom();
PrintArray();


void FillArreRandom()
{
    for (int i = 0; i <= array.Length - 1; i++) 
    array[i] = new Random().Next(0, 100);
}

void PrintArray()
{
    Console.Write($"[");
    for (int i = 0; i <= array.Length - 2; i++)
    { 
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}