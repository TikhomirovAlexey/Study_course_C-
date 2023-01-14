// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 10;

if (result < 0)
{
    result = -result;
}

Console.Write($"Конечная цыфра: {result}");
