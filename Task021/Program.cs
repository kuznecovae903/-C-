// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки:");
Console.WriteLine("X: ");
int numAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int numAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int numAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.WriteLine("X: ");
int numBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int numBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int numBz = Convert.ToInt32(Console.ReadLine());

double LenthLine (int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
if (Ax == Bx && Ay == By && Az == Bz) return 0;
int X = (Bx - Ax);
int Y = (By - Ay);
int Z = (Bz - Az);
return Math.Sqrt(X*X + Y*Y + Z*Z);
}

double lengthLine = LenthLine(numAx, numAy, numAz, numBx, numBy, numBz);

double lengthAB = Math.Round(lengthLine,2,MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между первой и второй точкой -> {lengthAB}");