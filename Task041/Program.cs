// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

void PrintArrayNum(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}


int[] EnterNumber(int count)
{
    int[] result1 = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите число номер {i + 1} : ");
        result1[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result1;
}
int CountPositive(int[] arr)
{
    int result2 = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result2++;
    }
    return result2;
}


Console.Write("Введите сколько чисел вы хотите ввести: ");
int countNumber = Convert.ToInt32(Console.ReadLine());
int[] array = EnterNumber(countNumber);
PrintArrayNum(array);
Console.Write($"Количество положительных чисел -> {CountPositive(array)}");
