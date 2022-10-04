﻿// Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

//Метод разворота массива:

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
//метод разворота массива 1:
void ReverseArray(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
// 0 1 2 3 4      0 1 2 3 4
//[1 2 3 4 5] -> [5 4 3 2 1]

    while (index1 < index2)
    {
        int obj = array[index1]; //1 /2
        array[index1] = array[index2]; //1-> 5 /2 ->4
        array[index2] = obj; //1 /2

        index1++;
        index2--;
    }
}

void ReverseArray2(int[] array)
{
    int size = array.Length; // 5
    for (int i = 0; i < size / 2; i++)
    {
        int obj = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = obj;
    }
}


int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);


Console.WriteLine("Hello, World!");
