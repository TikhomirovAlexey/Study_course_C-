// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

string PrintMatrix(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        str += "[";
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
            else str += $" {matrix[i, j],3}, ";
        }
        str += "]\n";
    }
    return str;

}

string PrintDictionary(int[,] matrix)
{
    string str = string.Empty;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        str += $"{matrix[0, i]} встречается {matrix[1, i]} раз(а).\n";
    }
    return str;

}

string PrintArray(int[] arr)
{
    string str = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (str == "[") str += arr[i];
        else str += $", {arr[i]}";
    }
    str += "]";
    return str;

}

int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count++] = matrix[i, j];
        }
    }
    return result;
}

int GetCountUniqueNumbers(int[] arr)
{
    int count = 1;
    int tmpNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (tmpNum != arr[i])
        {
            count++;
            tmpNum = arr[i];
        }

    }
    return count;
}

int[,] GetSameCountNumbers(int[] arr, int columns)
{
    int[,] tmpMatrix = new int[2, columns];
    int count = 0;
    tmpMatrix[0, 0] = arr[0];
    tmpMatrix[1, 0] = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (tmpMatrix[0, count] == arr[i]) tmpMatrix[1, count]++;
        else
        {
            count++;
            tmpMatrix[0, count] = arr[i];
            tmpMatrix[1, count] = 1;
        }
    }
    return tmpMatrix;
}

int[,] matrixNumbers = GenerateMatrix(3, 4, 0, 10);
Console.WriteLine(PrintMatrix(matrixNumbers));

int[] matrixToArray = MatrixToArray(matrixNumbers);
Console.WriteLine(PrintArray(matrixToArray));

Array.Sort(matrixToArray);

Console.WriteLine(PrintArray(matrixToArray));

int countUniqueNumbers = GetCountUniqueNumbers(matrixToArray);
Console.WriteLine(countUniqueNumbers);


int[,] matrixResult = GetSameCountNumbers(matrixToArray, countUniqueNumbers);
Console.WriteLine(PrintDictionary(matrixResult));
