﻿//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N lj n 
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
int i = -num;
while (i <= num)
{
    Console.Write($"{i},");
    i++;
}