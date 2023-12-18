//  Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

string Array2DToStringRD(char[,] array2D)
{
    string result = "";
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            result += array2D[i, j];
        }
    }
    return result;
}
string Array2DToStringRU(char[,] array2D)
{
    string result = "";
    for (int i = array2D.GetLength(0)-1; i >= 0; i--)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            result += array2D[i, j];
        }
    }
    return result;
}
string Array2DToStringLD(char[,] array2D)
{
    string result = "";
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = array2D.GetLength(1)-1; j >= 0; j--)
        {
            result += array2D[i, j];
        }
    }
    return result;
}
string Array2DToStringLU(char[,] array2D)
{
    string result = "";
    for (int i = array2D.GetLength(0)-1; i >= 0; i--)
    {
        for (int j = array2D.GetLength(1)-1; j >= 0; j--)
        {
            result += array2D[i, j];
        }
    }
    return result;
}
void printArray(char[,] array2D)
{
    Console.Write("[ ");
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j]+" ");
        }
        Console.Write("]");
        Console.WriteLine();
        if (i == array2D.GetLength(0) - 1) break;
        Console.Write("[ ");
    }
}
char[,] symbolArray =
{
    {'А', 'Б', 'В', 'Г' },
    {'Д', 'Е', 'Ё', 'Ж' }
};

Console.Clear();
Console.WriteLine("Массив:");
printArray(symbolArray);
Console.WriteLine("Распечатка слева направо, сверху вниз:");
Console.WriteLine(Array2DToStringRD(symbolArray));
Console.WriteLine("Распечатка слева направо, снизу вверх:");
Console.WriteLine(Array2DToStringRU(symbolArray));
Console.WriteLine("Распечатка справа налево, сверху вниз:");
Console.WriteLine(Array2DToStringLD(symbolArray));
Console.WriteLine("Распечатка справа нвлево, снизу вверх:");
Console.WriteLine(Array2DToStringLU(symbolArray));