// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] CreateArrayRndInt(int size, int min, int max)
void PrintArray(int[] array)
int GetSumPositiveElem(int[] 
int GetSumNegativeElem(int[] array)
{
    int sumNegative = default;

    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sumNegative += array[i];

    return sumNegative;
}
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");
