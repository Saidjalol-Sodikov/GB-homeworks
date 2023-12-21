//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// A (m, n) = {n+1, m=0; A(m-1, 1), m>0, n=0; A(m-1, A(m,n -1)), m>0, n>0.}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int A (int m, int n )
{
    if ( m == 0 ) return n+1;
    if ( m>0 && n == 0 ) return A (m-1, 1);
    if ( m>0 && n>0 ) return A(m-1,A(m,n-1));
    return 0;
}

//-----------------------------

int M = ReadInt("M: ");
int N = ReadInt("N: ");
Console.WriteLine(A(M, N));