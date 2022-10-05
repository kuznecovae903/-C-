﻿// Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void FindElemInArray(int[] array, int findInt)
{
    PrintArray(array);
    for (int i = 0; i < array.Length; i++)
        if (array[i] == findInt)
            Console.WriteLine("-> да");
     Console.WriteLine("-> нет");
    
}

bool FindElemInArrayBool(int[] array, int findInt)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == findInt)
            { return true;
                //result = true;
                //break;
            }
    return false;
    //result = false;
}

int[] arrayGlobal = CreateArrayRndInt(10, -3, 3);

Console. Write("Введите искомое число в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(arrayGlobal);
//if (FindElemInArray(arrayGlobal, num))
if (FindElemInArrayBool(arrayGlobal, num))
    Console.WriteLine("-> да");
else
    Console.WriteLine("-> нет");



