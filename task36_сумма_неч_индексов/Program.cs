/*
36. Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Аргументы, передаваемые в метод/функцию:
'18, 76, 11'
На выходе:
18      76      11  
Сумма нечетных элементов: 76
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write("\t");
    }
    System.Console.WriteLine();
}


int uSize = UserInOut("Введите размер массива: ");
int[] uArray = GetArray(uSize);
int sumNegArr = SumOddElements(uArray);
PrintArray(uArray);
System.Console.WriteLine($"Сумма нечетных элементов: {sumNegArr}");