// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели по порядку: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) Console.Write("Некорректное значение");
if (number >= 1 && number <= 5) Console.Write("Нет, не является выходным");
if (number == 6) Console.Write("Да, выходной день");
if (number == 7) Console.Write("Да, выходной день");