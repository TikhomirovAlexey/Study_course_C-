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

void PrintDictionary(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            Console.WriteLine($"{i} встречается {array[i]} раз(а).");
        }
    }
}

int GetMaxNumberInMatrix(int[,] matrix)
{
    int max = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (max < matrix[i, j]) max = matrix[i, j];
        }
    }
    return max;
}

int[] GetDictionaryCount(int[,] matrix, int length)
{
    int[] dictionaryCountNumbers = new int[length + 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int tmpIndex = matrix[i, j];
            dictionaryCountNumbers[tmpIndex]++;
        }
    }
    return dictionaryCountNumbers;
}

int[,] matrixNumbers = GenerateMatrix(4, 4, 0, 10);
Console.WriteLine(PrintMatrix(matrixNumbers));

int maxNumberInMatrix = GetMaxNumberInMatrix(matrixNumbers);
Console.WriteLine($"Max number - {maxNumberInMatrix}");

int[] dictionaryCount = GetDictionaryCount(matrixNumbers, maxNumberInMatrix);
PrintDictionary(dictionaryCount);