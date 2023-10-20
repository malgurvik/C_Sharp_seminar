// Функция ввода-вывода


Console.Clear();

int UserInOut(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
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


