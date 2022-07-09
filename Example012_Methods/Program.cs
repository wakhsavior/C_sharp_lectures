﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор: Савельев Денис");
}

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

// Вид 4

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

// Method1();
// Method2("Передаваемое сообщение");
// Method21("Передаваемое сообщение", 2);
// Method21(count: 2, msg: "Передаваемое сообщение");

// int year = Method3();

// Console.WriteLine(year);

// string res = Method4(10, "qwert");

// Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}