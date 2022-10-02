// Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

//Инициализация массива.Два способа:
//int[] array = new int[8];

//int[] array1 = new int[8] {1,2,3,4,5,6,7,8};
//var array2 = new int[8]; - это используется когда неявный тип преременной! 
//Здесь можно - справа понятно какой тип переменной
// Можно еще так:
//var rnd = new Random();

/*
for (int i = 0; i < array.Length; i++);
{
    int i = 0;
    array[i] = 34;
}
*/

/*
Иницмализация массива задаваемой длины:
Console.WriteLine("Введите размер массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
*/

int[] array = new int[8];
FillArreRandom();
PrintArray();

void FillArreRandom()
{
    for (int i = 0; i <= array.Length - 1; i++) array[i] = new Random().Next(0, 2);
}

void PrintArray()
{
    Console.Write($"[");
    for (int i = 0; i <= array.Length - 2; i++)
    { 
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

/*
Метод формирования случайного массива - препочтительный!
void FillArrayRandom(int[] array)
{
Random rnd = new Random();
for (int i = 0; i <= array.Length - 1; i++)
array[i] = rnd.Next(0, 2);
}
*/
/*
Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
for (int i = 0; i <= array.Length - 1; i++) array[i] = new Random().Next(0, 2);
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
Console.Write($"{array[array.Length - 1]}]");
}
*/