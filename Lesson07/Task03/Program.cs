//  Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

void FillArray (int[] array, int lL = 0, int rL=100)
{
    for (int i = 0;i< array.Length ; i++)
    {
        array[i] = new Random().Next(lL, rL+1);
    }
}
void ShowArray(int[] array, int i = 0)
{
    if (i >= array.Length) return;
    Console.Write(array[i]+" ");
    ShowArray(array, i+1);
}
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

//-----------------------

int size = ReadInt("Size of Array: ");
int[] arrayMain =  new int[size];
FillArray(arrayMain);
ShowArray(arrayMain);