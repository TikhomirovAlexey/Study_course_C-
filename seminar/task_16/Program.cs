// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите целое первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = GetNumber(firstNumber, secondNumber);

int GetNumber(int num1, int num2)
{
    if (num1 * num1 == num2) return 1;
    else if (num2 * num2 == num1) return 1;
    else return 0;
}

if (result == 1) Console.WriteLine("Кратно");
else Console.WriteLine("Некратно");