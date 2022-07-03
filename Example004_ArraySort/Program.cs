//Сортировка массива

int [] arr = {1, 2, 3, 5, 5, 8, 34, 9};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

PrintArray(arr);