// 14. Напишите программу, которая 
//принимает на вход число и 
//проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число, кратность которого мы будем проверять: ");
int numChek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число, на кратность которого мы будем проверять: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, на кратность которого мы будем проверять: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int checkMultiple(int check_arg, int divarg1, int divarg2)
{
    int result = 1;
    //if (numChek % firstNum == 0 && numChek % secondNum == 0) result = 0;
    if (check_arg % divarg1 == 0 && check_arg % divarg2 == 0) result = 0;
    return result;

}

//Console.WriteLine("Введите число, кратность которого мы будем проверять: ");
//int numChek = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите первое число, на кратность которого мы будем проверять: ");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число, на кратность которого мы будем проверять: ");
//int secondNum = Convert.ToInt32(Console.ReadLine());
int resultMetod = checkMultiple(numChek, firstNum, secondNum);

if (resultMetod == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}