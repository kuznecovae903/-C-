﻿// 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
CheckOnSquare(firstNum,secondNum);

void CheckOnSquare(int arg1, int arg2)
{
  int sqr = 1;
  if (arg1 < arg2)
  {
    sqr = (arg1 * arg1);
    if (sqr == arg2)
    {
        Console.WriteLine($"Число {arg2} является квадратом числа {arg1}");
    }
    else
    {
        Console.WriteLine($"Число {arg2} не является квадратом числа {arg1}");
    }
  }
  
    else
    {
        sqr = (arg2 * arg2);
        if (sqr == arg1)
        {
            Console.WriteLine($"Число {arg1} является квадратом числа {arg2}");
        }
        else
        {
            Console.WriteLine($"Число {arg1} не является квадратом числа {arg2}");
        }
    }
}
