//  Задайте произвольную строку.
// Выясните, является ли она палиндромом.

string InputString(string msg)
{
    Console.Write(msg);
    string result = Console.ReadLine();
    return result;
}
bool IsStrPallindrom(string msg)
{
    bool result = true;
    for (int i = 0; i < (msg.Length)/2; i++)
    {
        if (msg[i] != msg[msg.Length - 1-i])
        {
            result = false;
            return result;
        }
    }
    return result;
}

string strMain = InputString("Введите строку: ");
if (IsStrPallindrom(strMain))
{
    Console.WriteLine("Да, строка является палиндромом.");
}
else
{
    Console.WriteLine("Нет, строка не является палиндромом.");
}