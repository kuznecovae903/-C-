//Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
/*
string ReverseArrayFramework(string str)
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

string deciToBin(int num)
{
    string result = default;
    //int i = 0;
    while (num >= 1)
    {
        result = result + (num % 2);
        num = num / 2;
    }
    result = ReverseArrayFramework(result);
    return result;
}

Console.Write("Введите число для перевода, не равное 0: ");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = deciToBin(num);
Console.Write($"{num2}");
*/

//Решение с рекурсией (рекурсия возвращает "решение" в обратном порядке)
void ConvertToBin2(int num)
{
    string bin = default;

    if (num > 0)
    {
       bin += num % 2;         
       ConvertToBin2(num / 2);    //компилятор преобразует самостоятельно
    }
     
    Console.Write(bin);
}

Console.Write("Введите число для перевода, не равное 0: ");
int num = Convert.ToInt32(Console.ReadLine());
ConvertToBin2(num);
/*
// самый короткий вариант метода с рекурсией
void ConvertToBin3(int num)
{
    if (num == 0) return:
    ConvertToBin2(num / 2);    //компилятор преобразует самостоятельно
    Console.Write(num % 2);
}
*/