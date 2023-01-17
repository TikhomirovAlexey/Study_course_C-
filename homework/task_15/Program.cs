// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

bool GetWeekend(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool res = GetWeekend(number);
Console.WriteLine(res ? "выходной" : "не выходной");



