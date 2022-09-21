Console.WriteLine("Введите два числа и узнайте, является ли первое исло квдратом второго числа");
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int sqr_b = b * b;
if (sqr_b == a)
{
    Console.Write($"Да, первое число {a} - квадрат второго числа {b}");
}
else
{
    Console.Write($"Нет, первое число {a} - не квадрат второго числа {b}. Квадрат числа {b} - {sqr_b}");
}