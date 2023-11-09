/*
51. Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.
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

int SumDiag(int[,] array)
{
    int sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
}

// int SumDiag(int[,] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == j) result = result + array [i,j];
//         }
//     }
//     return result;        
// }

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
int uSum = SumDiag(uArr);
System.Console.WriteLine(uSum);