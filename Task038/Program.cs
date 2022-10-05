// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDoub(int size)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double DifferenceNumberArr(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum) maxNum = array[i];
        if (array[i] < minNum) minNum = array[i];
    }
    double result = maxNum - minNum;
    return result;
}

double[] arr = CreateArrayRndDoub(5);
PrintArray(arr);
double diffMaxMinNumArr = DifferenceNumberArr(arr);
Console.Write($"Разница между максимальным и минимальными занчениями массива: {diffMaxMinNumArr}");
