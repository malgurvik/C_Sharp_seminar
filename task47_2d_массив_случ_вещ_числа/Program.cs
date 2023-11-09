/*
Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5    7    -2   -0,2
 1   -3,3    8   -9,9
 8    7,8  -7,1    9
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] Get2dArray(int strg, int stlb)
{
    double[,] array = new double[strg, stlb];
    //Random rand = new Random();
    for (int i = 0; i < strg; i++)
    {
       for (int j = 0; j < stlb; j++)
       {
        //array[i, j] = Math.Round((rand.Next(-10, 11) + rand.NextDouble()), 2);
        array[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()),2);
       }
    }
    return array;
}



void Print2dArray(double[,] arr)
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
double[,] uArr = Get2dArray(userM, userN);
Print2dArray(uArr);
