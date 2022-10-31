//Задача 64: Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void NatNumbers(int num)
{
    if (num == 0) return;
    NatNumbers(num - 1);
    Console.WriteLine($"{num} ");
}

Console.WriteLine("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
NatNumbers(number);
*/

void NatNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NatNumbers(num - 1);
}

Console.WriteLine("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
NatNumbers(number);
Console.WriteLine();
