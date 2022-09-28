// Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Задайте номер четверти: ");
//int quarterNum = Convert.ToInt32(Console.ReadLine());
string quarterNum = Console.ReadLine();
//string FindRange (int num)
//{
    //if (num == 1) return "Диапазон координат X>0, Y>0";
    //if (num == 2) return "Диапазон координат X>0, Y<0";
    //if (num == 3) return "Диапазон координат X<0, Y<0";
    //if (num == 4) return "Диапазон координат X<0, Y>0";
    //return "Введены неверные координаты";
//}

string FindRange(string num)

{
    if (num == "1") return "Диапазон координат X>0, Y>0";
    if (num == "2") return "Диапазон координат X>0, Y<0";
    if (num == "3") return "Диапазон координат X<0, Y<0";
    if (num == "4") return "Диапазон координат X<0, Y>0";
    return "Введены неверные координаты";
}
string range = FindRange(quarterNum);
Console.WriteLine(range);