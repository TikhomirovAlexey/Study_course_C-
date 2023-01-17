// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

int GetNumber(int num)
{
    return num / 10 % 10;
}

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.Write("Вы ввели неправильное число! Введите целое трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int result = GetNumber(number);
Console.Write($"{number} -> {result}");