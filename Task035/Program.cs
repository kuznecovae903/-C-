// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


//Console.WriteLine("Hello, World!");
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

int CountofDeca(int[] array)
{
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <=99) result++;   
    }
    return result;
}

int[] arr = CreateArrayRndInt(10, 1 ,150);
PrintArray(arr);
int resultMetod = CountofDeca(arr);
Console.Write($"В массиве {resultMetod} значений, которые находятся в диапазоне от 10 до 99");

