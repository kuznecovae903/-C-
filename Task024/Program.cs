// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int res1 = (number % 10); Console.Write($"Третья цифра числа: {res1}");
}
if (number > 999)
{
    int res = (number / 10); 
    
    int count = 0;
    while (res > 999);
    count ++;
   // {
      //  int res = (number / 10); 
//        count++;
  //  }
    
    
    int res1 = (number % 10);    
        //if (res < 1000)
    //{
//                int res1 = (number % 10); 
    //}
//    }
    Console.Write($"Третья цифра числа: {res1}");
}