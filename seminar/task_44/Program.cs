// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetNumbersFibonacci(int num)
{
    int[] arrFib = new int[num];
    arrFib[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arrFib[i] = arrFib[i - 1] + arrFib[i - 2];
    }
    return arrFib;
}

string PrintArray(int[] arr)
{
    string str = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (str == string.Empty) str += arr[i];
        else str += $", {arr[i]}";
    }
    return str;

}

Console.Write("Введите положительное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while (userNumber <= 0)
{
    Console.Write("Неверный ввод. Введите положительное число: ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}

if (userNumber == 1)
{
    Console.WriteLine("Первое число Фибонвччи - 0.");
}
else
{
    int[] numbersFib = GetNumbersFibonacci(userNumber);
    Console.WriteLine($"{userNumber} -> {PrintArray(numbersFib)}");
}


