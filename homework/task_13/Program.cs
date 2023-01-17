﻿// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

int GetThirdNumber(int num)
{
    if (num < 100) return -1;
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

int result = GetThirdNumber(number);
Console.WriteLine(result == -1 ? "Третьей цифры нет." : $"Третия цифра -> {result}");
