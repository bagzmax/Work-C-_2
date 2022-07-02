

//string Method4(int count, string text)
// {
//     string result = String.Empty; // пустая строка
//     for (int i = 0; i < count; i++) // инициализация счетчика; проверка условия; инкримент
//     {            
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// System.Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}