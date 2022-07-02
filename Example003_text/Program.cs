// Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “и” заменить большими “И”, а большие “С” заменить
//маленькими “с”.

string text = "Дан текст. В тексте нужно все пробелы заменить черточками";

// string s = "qwerty"
//             0123
//s[3] // r

string Replase(string text, char oldValue, char newValue) // длина строки, старый символ, новый символ
{
    string result = String.Empty;

    int length = text.Length; // количество символов в стоке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
System.Console.WriteLine(newText);