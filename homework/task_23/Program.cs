// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void GetCubesTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5}{Math.Pow(count, 3),5}");
        count++;
    }

}

Console.Write("Введите положительное натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while (userNumber < 1)
{
    Console.Write("Вы ввели неправильное число. Введите положительное натуральное число: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

GetCubesTable(userNumber);