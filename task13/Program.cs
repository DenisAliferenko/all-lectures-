// // // вид 1
// void Method1()
// //     {
// //         Console.WriteLine("Автор, Денис Алиференко ");
// //     }
// // // Method1();
// void Method2(string msg)
// // {
// //     Console.WriteLine(msg);

// // }
// // // Method2("Текст сообщения");
// // // Method2(msg :"Текст сообщения"); // аргументы именованные

// void Method21(string msg, int count)
// // {
// //     int i = 0;
// //     while (i < count)
// //     {
// //         Console.WriteLine(msg);
// //         i++;
// //     }

// // }
// // //Method21("Tekst", 4);
// // //Method21(msg: "Tekst", count: 4);
// // //Method21(count: 4, msg: "new tekst");

// int Method3()
// // {
// //  return DateTime.Now.Year;
// // }
// // // int year = Method3();
// // // Console.WriteLine(year);

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }

    return result;
}

string res = Method4(1100, "z Z    z");
Console.WriteLine(res);
