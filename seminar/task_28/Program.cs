// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetMulti(int num)
{
    int multi = 1;
    for (int i = 1; i <= num; i++)
    {
        multi *= i;
    }
    return multi;
}

int Factorial(int num)
{
    if (num == 1 || num == 0) return 1;
    return num * Factorial(num - 1);
}

Console.Write("Введите целое положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while (userNumber < 0)
{
    Console.Write("Вы ввели неправильное число! Введите целое положительное число: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

int multiNumbers = GetMulti(userNumber);

int facNumbers = Factorial(userNumber);

Console.WriteLine($"Произведение чисел числа {userNumber} = {multiNumbers}");
Console.WriteLine($"Факториал числа {userNumber} = {multiNumbers}");


