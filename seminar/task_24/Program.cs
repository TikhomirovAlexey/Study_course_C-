// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите целое положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while (userNumber < 0)
{
    Console.Write("Вы ввели неправильное число! Введите целое положительное число: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

int sumNumbers = GetSum(userNumber);
Console.WriteLine(sumNumbers);