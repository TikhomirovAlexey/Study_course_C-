// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.Write("Введите натуральное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

while (userNum <= 0)
{
    Console.Write("Вы ввели неверное число! Введите положительное число: ");
    userNum = Convert.ToInt32(Console.ReadLine());
}

int count = 2;

while (count <= userNum)
{
    Console.Write($"{count} ");
    count += 2;
}
