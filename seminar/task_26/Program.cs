// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetLengthNumber(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }

    return count;
}

Console.Write("Введите целое положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int lengthNumber = userNumber < 0 ? GetLengthNumber(-userNumber) : GetLengthNumber(userNumber);

Console.WriteLine($"Длина числа {userNumber} - {lengthNumber} цифр(ы).");

