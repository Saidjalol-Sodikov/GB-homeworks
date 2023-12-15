//  Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива. Под удалением понимается
// создание нового двумерного массива без строки и столбца

int[,] Create2DArray(int rowns, int colums)
{
    int[,] result = new int[rowns, colums];
    return result;
}

void Full2DArrayRandInt(int[,] array2D, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int k = 0; k < array2D.GetLength(1); k++)
        {
            array2D[i, k] = rand.Next(min, max + 1);
        }
    }
}

void Show2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int k = 0; k < array2D.GetLength(1); k++)
        {
            Console.Write(array2D[i, k] + " ");
        }
        Console.WriteLine();
    }
}

int GiveRandInt(int min, int max)
{
    int result = new Random().Next(min, max);
    return result;
}

int[] FindIndexOfMinOf2DArrey(int[,] array2D)
{
    int min = 0;
    int[] result = { 0, 0 };
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int k = 0; k < array2D.GetLength(1); k++)
        if (min > array2D[i,k])
        {
            min = array2D[i,k];
            result[0] = i;
            result[1] = k;
        }
    }
    return result;
}

int[,] DeleteMinRownColumIn2DArray(int[,] array2D, int rownIndex, int columIndex)
{
    int[,] result = new int[array2D.GetLength(0) - 1, array2D.GetLength(1) - 1];
    for (int i = 0, iNew = i; i < array2D.GetLength(0); i++)
    {
        if (i != rownIndex)
        {
            for (int k = 0, kNew = k; k < array2D.GetLength(1); k++)
            {
                if (k != columIndex)
                {
                    result[iNew,kNew] = array2D[i, k];
                    kNew++;
                }
            }
            iNew++;
        }
    }
    return result;
}

//---------------------------------------
int leftLimit = 1, rightLimit = 10;
Console.WriteLine($"Параметры двумерного массива сгенерируются случайно в пределах от {leftLimit} до {rightLimit}.");
int[,] arrayMain = Create2DArray(GiveRandInt(leftLimit, rightLimit), GiveRandInt(leftLimit, rightLimit));
Full2DArrayRandInt(arrayMain, -1000, 1000);
Console.WriteLine("Исходный массив:");
Show2DArray(arrayMain);
int[] indexes = FindIndexOfMinOf2DArrey(arrayMain);
Console.WriteLine($"Индекс наименьшего числа массива сверху: [{indexes[0]}, {indexes[1]}]");
int[,] arrayNew = DeleteMinRownColumIn2DArray(arrayMain, indexes[0], indexes[1]);
Console.WriteLine("Отредактированный массив:");
Show2DArray(arrayNew);
