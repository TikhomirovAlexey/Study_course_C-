/*
* Написать программу, котрая принимает на вход натуральное число N
* и выдет таблицу квадратов чисел от 1 до N.
*/

void GetSquaresTable(int num)
{
    int count = 1;
    Console.Write($"{num} -> ");
    while (count <= num)
    {
        Console.Write($"{count * count} ");
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

GetSquaresTable(userNumber);