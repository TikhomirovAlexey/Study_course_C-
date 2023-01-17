// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите целое первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваши числа: {firstNumber} и {secondNumber}.");

int remains = GetNumber(firstNumber, secondNumber);

int GetNumber(int num1, int num2)
{
    int result = num1 % num2;
    return result;
}

if (remains == 0) Console.WriteLine($"Число: {firstNumber} кратно {secondNumber}.");
else Console.WriteLine($"Число: {firstNumber} не кратно {secondNumber}. Остаток от деления {remains}");
