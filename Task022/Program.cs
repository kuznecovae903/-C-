// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

int count = 1;

string StringOfSqure (int num)
{
    return $"|{num} | {num*num} |";
}

while (count <= numX)
{
    Console.WriteLine(StringOfSqure(count));
    count++;
}