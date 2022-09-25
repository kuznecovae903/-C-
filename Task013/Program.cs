// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int res1 = (number % 10); Console.Write($"Третья цифра числа: {res1}");
}
if (number >= 1000)
{
    int num1 = (number / 10); 
    if (number > 99 && number < 1000)
    {
        int res1 = (number % 10); Console.Write($"Третья цифра числа: {res1}");   
    }
}
if (number <= 99) Console.Write("Третьей цифры нет");