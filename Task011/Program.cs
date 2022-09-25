// 11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этогочисла.
//456 -> 46
//782 -> 72
//918 -> 98


int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число {number}");
int first = number /100;
int second = number % 10;
int result = first*10 + second;
Console.WriteLine($"Требуемое двухзначное число: {result}");
