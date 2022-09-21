Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7 || num < 1)
{
    Console.WriteLine("Вы ввели некорректное значение");
}
if (num == 1)
{
    Console.WriteLine("Это понедельник."); 
}
if (num == 2)
{
    Console.WriteLine("Это вторник.");
}
if (num == 3)
{
    Console.WriteLine("Это среда.");
}
if (num == 4)
{
    Console.WriteLine("Это четверг.");
}
if (num == 5)
{
    Console.WriteLine("Это пятница.");
}
if (num == 6)
{
    Console.WriteLine("Это суббота.");
}
if (num == 7)
{
    Console.WriteLine("Это воскресенье.");
}