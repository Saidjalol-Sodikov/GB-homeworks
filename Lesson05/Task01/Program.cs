//  Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

int InputToInt(string msg)
{
    int result = 0;
    Console.Write(msg);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

bool HaveElementOf2DArray(int arrayX, int arrayY, int[,] array2D)
{
    bool result = false;
    if (array2D.GetLength(0) > arrayX && array2D.GetLength(1) > arrayY)
    {
        result = true;
    }
    return result;
}

void ShowElementOf2DArray(int arrayX, int arrayY, int[,] array2D)
{
    Console.WriteLine($"Элемент массива с индексом [{arrayX},{arrayY}]: {array2D[arrayX, arrayY]}");
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
int coorX = InputToInt("Введите значение Х: ");
int coorY = InputToInt("Введите значение Y: ");
if (HaveElementOf2DArray(coorX, coorY, arrayMain))
{
    ShowElementOf2DArray(coorX, coorY, arrayMain);
    Show2DArray(arrayMain);
}
else
{
    Console.WriteLine("Такого элемента нет.");
}