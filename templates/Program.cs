
Console.Clear();

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

//==============================================================================

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[,] Get2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

double[,] Get2DArray(int row, int column)
{
    double[,] array = new double[row, column];
    //Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
       for (int j = 0; j < column; j++)
       {
        //array[i, j] = Math.Round((rand.Next(-10, 11) + rand.NextDouble()), 2);
        array[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()),2);
       }
    }
    return array;
}

//==============================================================================

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

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(200);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");// [5, 7, 1, 4
    }
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.Write("]");
    Console.ResetColor();
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void Print2DArray(int[,] arr)
{
    System.Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + arr.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"[" + i + "] \t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($" {arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

//==============================================================================

string UserEnter(string message)
{
    System.Console.WriteLine(message);
    string result = Convert.ToString(Console.ReadLine());
    return result;
}

string userInput = UserEnter("Введите числа массива через пробел: ");
var arString = userInput.Split(' ');
int[] uArray = Array.ConvertAll(arString, s => int.Parse(s));