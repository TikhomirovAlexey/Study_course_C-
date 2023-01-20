// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



int GetNumber(int num)
{
    int secondNum = 0;
    while (num > 0)
    {
        secondNum = secondNum * 10 + num % 10;
        num /= 10;
    }
    return secondNum;
}

Console.Write("Введите положительное натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while (userNumber < 0)
{
    Console.Write("Отрицательное число не может быть палиндромом. Введите положительное натуральное число: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

int result = GetNumber(userNumber);
Console.WriteLine(result == userNumber ? $"Число {userNumber} является палиндромом." : $"Число {userNumber} не является палиндромом.");


// Вариант с пятизначным числом
// bool GetAnswer(int num) 
// {
//     return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
// }

// Console.Write("Введите положительное натуральное число: ");
// int userNumber = Convert.ToInt32(Console.ReadLine());

// while (userNumber < 0 || userNumber > 99999 || userNumber < 10000)
// {
//     Console.Write("Вы ввели неправильное число. Введите положительное натуральное число: ");
//     userNumber = Convert.ToInt32(Console.ReadLine());
// }

// bool result = GetAnswer(userNumber);
// Console.WriteLine(result ? $"Число {userNumber} является палиндромом." : $"Число {userNumber} не является палиндромом.");