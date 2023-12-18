//  Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

string InputString(string msg)
{
    Console.Write(msg);
    string result = Console.ReadLine();
    return result;
}
string[] MakeStringArray(string str, char space) 
{ 
    string[] result = str.Split(space);
    return result;
}
string[] InversStrArray(string[] str)
{
    for (int i = 0; i<str.Length/2; i++)
    {
        string temp = str[i];
        str[i] = str[str.Length-i-1];
        str[str.Length-i-1] = temp;
    }
    return str;
}
void PrintStringArray(string[] array, char space)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]+space);
    }
}

string strMain = InputString("Введите строку: ");
char destructor = ' ';
string[] strArrayMain = MakeStringArray(strMain, destructor);
strArrayMain = InversStrArray(strArrayMain);
PrintStringArray(strArrayMain, destructor);
