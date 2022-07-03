//! Виды методов!

//! Вид 1 - не принимают никаких аргмуентов и ничего не возвращают

void Method1()
{
    System.Console.WriteLine("Имя пользователя:");
}
//Method1(); // Вызов метода

//*****************************************************************************

//! Вид 2 - могут принмать какие-то аргументы, но ничего не возвращают

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count) // вывод сообщения msg несколько раз (count)
{
    int i=0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++; // инкримент - увеличение на 1; дикремент - уменьшение на 1
    }
}
//Method21(msg: "Текст", count: 4); //именованные аргументы
//Method21(count: 5, msg: "Текст new"); // МОЖНО менять местами

//***********************************************************************************************

//! Вид 3 - не принимают никаких аргмуентов, но могут возвращать (генирирование данных)

int Method3()
{
    return DateTime.Now.Year; // возрат чего-то
}
int year = Method3();
//System.Console.WriteLine(year);

//*************************************************************************************************

//! Вид 4 - могут принимать какие-то аргументы, и могут возвращать

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "resurs");
//Console.WriteLine(res);
Console.WriteLine(Method4(10, "resurs"));
