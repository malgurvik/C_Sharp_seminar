/*46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.4
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
// void Print2dArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i, j] + "\t");
//         }
//     System.Console.WriteLine();
//     }
// }

void Print2dArray(int[,] arr)
{
    System.Console.Write($"[ ]\t");
    int start =0;
    for (int i = start; i < start+arr.GetLength(1); i++)
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


int userM = UserInOut("Введите число строк: ");
int userN = UserInOut("Введите число столбцов: ");
int[,] uArr = Get2dArray(userM, userN);
Print2dArray(uArr);
