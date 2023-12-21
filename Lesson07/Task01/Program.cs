//  Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int ReadInt (string msg)
{
    Console.Write (msg);
    return Convert.ToInt32 (Console.ReadLine());
}
void PrintDistance (int LeftLimit, int RightLimit)
{
    if (RightLimit < LeftLimit) return;
    Console.Write(LeftLimit+" ");
    PrintDistance(LeftLimit +1, RightLimit);
}

//-----------------

int M = ReadInt("M: ");
int N = ReadInt("N: ");
PrintDistance(M, N);
