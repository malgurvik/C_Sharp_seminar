/*
45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] CloneArray(int[] array)
{
    int[] cloneArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        cloneArray[i] = array[i];
    }
    return cloneArray;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}


int userSize = UserInOut("Введите размер массива: ");
int[] uArray = GetRandomArray(userSize);
PrintArray(uArray);
System.Console.WriteLine();
int[] clone = CloneArray(uArray);
PrintArray(clone);