/*
48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5
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
         array[i, j] = i+j;
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

int userM = UserInOut("Введите число M: ");
int userN = UserInOut("Введите число N: ");
int[,] uArr = Get2dArray(userM, userN);
Print2dArray(uArr);