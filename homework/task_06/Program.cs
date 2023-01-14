// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0)
{
    Console.Write("Вы ввели 0");
}
else if (num % 2 == 0)
{
    Console.Write($"Число {num} четное.");
}
else
{
    Console.Write($"Число {num} нечетное.");
}