// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число А, которое требуется возвести в степень В:");
Console.WriteLine("число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB < 1) 
{
    Console.WriteLine("Вы ввели некорректное значение");
}
else
{
    int result = StepenNumber(numA, numB);
    Console.WriteLine($"Число {numA}, возведенное в степень {numB}, равно {result}");
}



int StepenNumber(int num1, int num2)
{
    int stepenNumber = 1;
    for (int i = 0; i < num2; i++) 
    {
        stepenNumber = (stepenNumber * num1); 
    }
    return stepenNumber;
}    
 

/*
Второй вариант
int StepenNumber(int num1, int num2)
{
    int stepenNumber = 1;
    int count = 0;
    while (count < num2)
    {
        stepenNumber = stepenNumber * num1;
        count++;
    }
    return stepenNumber;
}
*/


