// заменить одни символы текста на другие.

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы ьы вящои приступом согласие прусского корля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
            // 012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
      
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

