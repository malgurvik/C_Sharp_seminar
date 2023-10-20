/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

Console.Clear;

int[] GetArray()
{
    int[] array = new int[12];
    for (int i = 0; i < 12; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");

        if (arr[i] < 0)
        {
            sumNegative += arr[i];
        }
        else if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
    }


    System.Console.WriteLine("Сумма положительных шчисел равна " + sumPositive);
    System.Console.WriteLine("Сумма отрицательных чисел равна " + sumNegative);
}

int[] userArray = GetArray();
PrintArray(userArray);