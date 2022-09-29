// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//Код округления 
//(функция "MidpointRoundng.ToZero" подволяет просто откинуть цифры после 2 цифры после запятой)
//double num = 3.09987565; // 3.09
//double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
//System.Console.WriteLine(numRound);

Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("X: ");
int numAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int numAy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("X: ");
int numBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int numBy = Convert.ToInt32(Console.ReadLine());

double LenthLine (int Ax, int Ay, int Bx, int By)
{
if (Ax == Bx && Ay == By) return 0;
int X = (Bx - Ax);
int Y = (By - Ay);
return Math.Sqrt(X*X + Y*Y);
}

double lengthAB = LenthLine(numAx,numAy,numBx,numBy); 

double length = Math.Round(lengthAB,2,MidpointRounding.ToZero);


//double numZ = Math.Sqrt(numX*numX + numY*numY);

Console.WriteLine($"Расстояние между двух точек -> {length}");



