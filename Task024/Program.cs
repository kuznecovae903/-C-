// Задача 24: Напишите программу, которая
//принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

//1+2+3+4+5+6+7+8=

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumber}");

//метод 1 - этот метод используется когда известно количество итераций

/*
int SumNumber (int num)
{
  int sum = default;
    for (int i = 0; i <=num; i++);
    {
        sum = sum + i;
    }
}
*/
//метод 2 - этот метод используется когда НЕ известно количество итераций

int SumNumber (int num)
{
    int sum = default;
    int counter = 1;
    while (counter <= num )
    {
        sum += counter;
        counter++;
    }
    return sum;
}
