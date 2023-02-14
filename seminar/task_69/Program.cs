// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int DegreelNumbers(int num, int deg)
{
    if (deg == 1) return num;
    return num * DegreelNumbers(num, deg - 1);
}


Console.Write("Введите первое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
int degree = Convert.ToInt32(Console.ReadLine());


int result = DegreelNumbers(number, degree);
Console.Write(result);