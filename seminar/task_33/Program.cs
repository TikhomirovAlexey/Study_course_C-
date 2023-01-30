// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void GenerateArray(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
}

string PrintArray(int[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        str += $" {arr[i]}";
    }
    str += " ]";
    return str;

}

bool FindMatch(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int[] arrayNumbers = new int[10];
GenerateArray(arrayNumbers, -10, 10);

Console.Write("Введите число от -10 до 10: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

bool resul = FindMatch(arrayNumbers, userNumber);
Console.WriteLine(resul ? $"Число {userNumber} присутствует в массиве {PrintArray(arrayNumbers)}." : $"Число {userNumber} отсутствует в массиве {PrintArray(arrayNumbers)}.");