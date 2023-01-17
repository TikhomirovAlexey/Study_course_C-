// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

int GetNumber(int num)
{
    return num / 10 % 10;
}

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(number);
Console.Write($"{number} -> {result}");