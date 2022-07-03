﻿//Сортировка массива

int [] arr = {8, 7, 333, 5, 55, 88, 34, 9};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            {
                if (array[j] > array[maxPosition]) maxPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;

    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);