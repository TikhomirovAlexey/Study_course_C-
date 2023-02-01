// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int GetBinaryNumber(int number)
{
    int multiNum = 1;
    int res = 0;
    for (; number > 0; number /= 2)
    {
        res += number % 2 * multiNum;
        multiNum *= 10;
    }
    return res;
}


Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber == 1) Console.WriteLine($"Число 1 в бинарной системе 01.");
else
{
    int binaryNumber = GetBinaryNumber(userNumber);
    Console.WriteLine($"Число {userNumber} в бинарной системе {binaryNumber}.");
}
