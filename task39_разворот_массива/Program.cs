/*
39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами: 
1) менять числа местами в исходном массиве; 
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
*/


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

int[] Reverse(int[] array)
{
    int tmp = 0; // [4, 8, 1, 3] [3, 8, 1, 4] []
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 - i] = tmp;    
    }
    return array;
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
}


int userSize = UserInOut("Введите размер массива: ");
System.Console.WriteLine();
int[] uArray = GetRandomArray(userSize);
PrintArray(uArray);
System.Console.Write(" -> ");
int[] revArray = Reverse(uArray);
PrintArray(revArray);