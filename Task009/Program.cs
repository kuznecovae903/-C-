// Задача 9. Напишите программу, которая 
//выводит случайное число из отрезка [10, 99] и 
//показывает  наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

int number = new Random().Next(10,100);
System.Console.WriteLine($"Случайное число из отрезка 10 - 99 -{number}");
//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit == secondDigit) System.Console.WriteLine("Цифры одинаковые");
//if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {number} -> {firstDigit}");
//else Console.WriteLine ($"наибольшая цифра числа {number} -> {secondDigit}");

//int max = firstDigit > secondDigit ? firstDigit : secondDigit;
// это тернальный оператор (если перем 1 больше перем 2, то в max - премен 1, если нет то перем 2)

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    //if (firstDigit > secondDigit) return firstDigit;
    //return secondDigit;
    if(firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
} 

bool IsEqualDigit(int num1, int num2)
{
    return num1 == num2;
}
int maxDigit = MaxDigit(number);
Console.WriteLine ($"наибольшая цифра числа {number} -> {MaxDigit}");
