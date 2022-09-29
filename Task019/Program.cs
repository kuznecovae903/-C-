// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int numFive = Convert.ToInt32(Console.ReadLine());

if (numFive > 9999 && numFive <= 99999)
{
    string rez = Palindromtest(numFive);
    Console.WriteLine(rez);
}  
else
{
    Console.Write("Введенное число не пятизначное.");
}

string Palindromtest(int number)
{
    int number1 = (number/10000);
    int number2 = ((number/1000)%10);
    int number4 = ((number/10)%10);
    int number5 = (number%10);
    if (number1 == number5 && number2 == number4) return $"Число {number} является палиндромом";
    return $"Число {number} не является палиндромом";
}
//string rez = Palindromtest(numFive);
//Console.WriteLine(rez);


