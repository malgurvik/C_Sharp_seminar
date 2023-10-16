/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/


int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
}

int[] userArray = GetRandomArray(9);
PrintArray(userArray);