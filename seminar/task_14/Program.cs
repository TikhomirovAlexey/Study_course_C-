// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(number);

int GetNumber(int num)
{
    int res1 = num % 7;
    int res2 = num % 23;
    if (res1 == 0 && res2 == 0) return 1;
    else return 0;
}

if (result == 1) Console.WriteLine("Кратно 7 и 23");
else Console.WriteLine("Не кратно 7 и 23");