string text = "Итак, сегодня мы разобрались с циклами в C#, посмотрели как они работают на примере поиска простых чисел, а также научились управлять циклами в нашем приложении с помощью операторов continue и break. При этом, я постарался сделать так, чтобы в примерах было задействовано максимальное количество конструкций и операторов, которые мы изучили ранее.";

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
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
