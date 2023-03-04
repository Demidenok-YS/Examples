// Функции в программировании
// 1. Ничего не принимают, ничего не возвращают (void)
// Например, нам необходимо указать авторство

void Method1()
{
    Console.WriteLine(" Автор Фамилия И.О.");
}

Method1();    // вызов метода

// 2. Что-то принимают, ничего не возвращают (void)

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text");
Method2(msg: "Text");  // именованное значение

- - - 

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);

// можем указать явно
Method21(msg: "Текст", count: 4);


// 3. Ничего не принимают, что-то возвращают

int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// 4. Что-то принимают, что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // инициализация пустой строки

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

