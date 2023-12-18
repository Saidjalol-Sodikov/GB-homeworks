//  Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string InputString(string msg)
{
    Console.Write(msg);
    string result = Console.ReadLine();
    return result;
}
string RegistrFalling (string str)
{
    string result = "";
    char[] bigLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N',
        'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'W', 'V', 'X', 'Y', 'Z'};
    char[] smlLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n',
        'o', 'p', 'q', 'r', 's', 't', 'u', 'w', 'v', 'x', 'y', 'z' };
    for (int i = 0; i < str.Length; i++)
    {
        bool addNewLetter = false;
        for (int j = 0; j < bigLetters.Length; j++)
        {
            char temp = str[i];
            if (temp == bigLetters[j])
            {
                result += smlLetters[j];
                addNewLetter = true;
                break;
            }
        }
        if (addNewLetter == false)
        {
            result += str[i];
        }
    }
    return result;
}
//---------------------------
string stringMain = InputString("Введите строку из букв латинского алфавита: ");
stringMain = RegistrFalling(stringMain);
Console.WriteLine(stringMain);