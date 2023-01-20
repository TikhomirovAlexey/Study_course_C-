// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetСoordinates(int ax, int ay, int bx, int by)
{
    double res = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
    return Math.Round(res, 2);
}

Console.Write("Введите AX: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите AY: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BX: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите BY: ");
int bY = Convert.ToInt32(Console.ReadLine());

double result = GetСoordinates(aX, aY, bX, bY);
Console.WriteLine($"Расстояние между точками: {result}");


