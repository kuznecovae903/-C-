// Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int res1 = (number % 10); Console.Write($"Третья цифра числа: {res1}");
}
if (number > 999)
{
    //{
    //int count = 0;
    // while (count > 999); 
    //int res = (number / 10);
    //if (res > 999)
   // {
        int GetSecondDigit(int res)
        {
            int count = 0;
            while (res > 999) 
            {
                res /= 10;
                count++;
            }    
            res %= 10;
            return res;
        }
        //if (res > 999) ;
        //int res = (number / 10);
        //int count = 0;
        //count++;
        //(res > 999);
        //int count = 0;
        //count++;
   // }
    //while (res > 999); 
    //int count = 0;
    //count++;
    //{
    //        int res = (number / 10); 
    //      count++;
    // }
    //int res1 = (number % 10);

    //if (res < 1000)
    //{
    //                int res1 = (number % 10); 
    //}
    //    }
    //Console.Write($"Третья цифра числа: {res1}");
    Console.Write($"Третья цифра числа: {GetSecondDigit(number)}");

}
if (number <= 99) Console.Write("Третьей цифры нет");