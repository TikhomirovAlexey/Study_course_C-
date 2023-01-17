// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int GetMaxNum(int num)
{
    int firtsNum = num / 10;
    int secondNum = num % 10;

    if (firtsNum > secondNum) return firtsNum;
    return secondNum;
}

int randomNumber = Convert.ToInt32(new Random().Next(10, 100));
Console.WriteLine($"Случаное число - {randomNumber}");

int res = GetMaxNum(randomNumber);
Console.WriteLine($"Максимальная цифра - {res}");
