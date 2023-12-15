//  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

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

int FindIndexOfMinSumRownOf2DArrey(int[,] array2D)
{
    int sum = 0, result = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int rownSum = 0;
        for (int k = 0; k < array2D.GetLength(1); k++)
        {
            rownSum = rownSum + array2D[i, k];
        }
        if (rownSum < sum)
        {
            sum = rownSum;
            result = i;
        }
    }
    return result;
}

int GiveRandInt(int min, int max)
{
    int result = new Random().Next(min, max);
    return result;
}
//---------------------------------------
int leftLimit = 1, rightLimit = 10;
Console.WriteLine($"Параметры двумерного массива сгенерируются случайно в пределах от {leftLimit} до {rightLimit}.");
int[,] arrayMain = Create2DArray(GiveRandInt(leftLimit, rightLimit), GiveRandInt(leftLimit, rightLimit));
Full2DArrayRandInt(arrayMain, -100, 100);
Show2DArray(arrayMain);
Console.WriteLine($"Сумма строки с индексом {FindIndexOfMinSumRownOf2DArrey(arrayMain)} является наименьшей.");