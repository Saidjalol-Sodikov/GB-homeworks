//  Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

void Change2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int temp = array2D[0,i];
        array2D[0,i] = array2D[array2D.GetLength(0)-1,i];
        array2D[array2D.GetLength(0) - 1, i] = temp;
    }
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
Console.WriteLine("Исходный массив:");
Show2DArray(arrayMain);
Change2DArray(arrayMain);
Console.WriteLine("Отредактированный массив:");
Show2DArray(arrayMain);