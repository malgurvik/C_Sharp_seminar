/*
49. Задайте двумерный массив. Найдите элементы, у которых оба 
индекса чётные, и замените эти элементы на их квадраты.
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] Get2dArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
       for (int j = 0; j < stlb; j++)
       {
         array[i, j] = new Random().Next(0, 10);
       }
    }
    return array;
}

int[,] FindSquarePos(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] *=2;
        }
    }
    return array;
}

void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
    System.Console.WriteLine();
    }
    
    
}

int userM = UserInOut("Введите число строк: ");
int userN = UserInOut("Введите число столбцов: ");
int[,] uArr = Get2dArray(userM, userN);
Print2dArray(uArr);
System.Console.WriteLine();
int[,] uSquare = FindSquarePos(uArr);
Print2dArray(uSquare);
