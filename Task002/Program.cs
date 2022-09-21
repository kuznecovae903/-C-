﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа и узнайте, какое больше, а какое меньше");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine($"Числа {a} и {b} равны.");
}
else if (a > b)
    {
        Console.WriteLine($"Первое число {a} большее, второе число {b} меньшее. Max = {a}");
    }
    else
    {
        Console.WriteLine($"Первое число {a} меньше, второе число {b} большее. Max = {b}");
    }