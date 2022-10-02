// Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int prodNumber = ProdNumber(number);
//Console.WriteLine($"Произведение чисел от 1 до {number}: {prodNumber}");

//int ProdNumber (int number)
//{
  //  int sum = 1;
    //for (int i = 1; i < number; i++)
    //{
      //  sum = sum * i;
    //}
    //return sum;
//}
/*
int Factorial (int numb)
{
    int fact = numb;
    while (numb > 1)
    {
        fact = fact * (numb - 1);
        numb --;
    }
    return fact;
}
int factorial = Factorial (number);
Console.WriteLine (factorial);
*/
int MakeFactorial (int num)
{
  int factorial = 1;
  for (int i = 1; i <= num; i++)
  {
    factorial *= i;
  }
  return factorial;
}
int result = MakeFactorial(number);
Console.WriteLine($"{number} -> {result}");