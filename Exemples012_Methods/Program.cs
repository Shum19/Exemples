// Вид 1 метод ничего не возвращает и не требует аргументов в скобках
void Method1 ()
{
    Console.WriteLine("Автор...");
}
Method1();

// Вид 2 метод ничего не возвращает НО требует аргументов в скобках и данном случае
// аргумент это строка 
void Method2 ( string msg)
{
    Console.WriteLine (msg);
}
Method2(msg:"Текст собщения");

// Вид 2a метод ничего не возвращает НО требует аргументов в скобках и данном случае
// аргумент это строка и также можно добавть еще несколько аргументов другого или тоже типа
// например если необходимо повторить несколько действий с первым аргументом
void Method2a ( string msg, int times)
{
    int i = 0;
    while ( i < times)
    {
        Console.WriteLine (msg);
        i++;
    }
}
Method2a($"Я повторюсь - 2 раза", 2);
Method2a(times: 3, msg: "А тут 3 раза");

// Вид 3 метод ВОЗВРАЩАЕТ значение согласно его тиипа int, String, booling и так далее. 
// В данном примере НЕ требует аргументов в скобках.
int Method3 ()
{
    return DateTime.Now.Year;
}
 int year = Method3();
 Console.WriteLine(year);

// Вид 4 метод ВОЗВРАЩАЕТ значение согласно его тиипа int, String, booling и так далее. 
// В данном примере так же необходим ввод вргументов аргументов в скобках.

String Method4 (int count, string text)
{
    int i = 0;
    string result =  String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string test = Method4 (5, "yes, ");
Console.WriteLine(test);

// Вид 4a метод ВОЗВРАЩАЕТ значение согласно его тиипа int, String, booling и так далее. 
// В данном примере так же необходим ввод вргументов аргументов в скобках. 
// Плюс цикл for

String Method4a (int count, string text)
{
    string result =  String.Empty;
    for (int i =0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string test2 = Method4a (5, "no, ");
Console.WriteLine(test2);

for ( int i = 2; i < 10; i++)
{
    for ( int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); 
    }
    Console.WriteLine();
}
