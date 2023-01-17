// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

bool GetWeekend(int num)
{
    return num == 6 || num == 7;
}

Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1 || number > 7)
{
    Console.Write("Вы ввели неправильный порядковый номер! Введите число от 1 до 7, включаяя последнее: ");
    number = Convert.ToInt32(Console.ReadLine());
}

bool res = GetWeekend(number);
Console.WriteLine(res ? "выходной" : "не выходной");



