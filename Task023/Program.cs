// Задача 23
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

if (numX > 0)
{
    int i = 1;

    while (i <= numX)
    {
        Console.WriteLine(StringOfQub(i));
        i++;
    }
}
else
{
    Console.WriteLine("Вы ввели некорретное значение");
}

string StringOfQub (int number)
{
    return $"|{number} | {number*number*number} |";
}

//while (i <= numX)
//{
    //Console.WriteLine(StringOfQub(i));
    //i++;
//}

