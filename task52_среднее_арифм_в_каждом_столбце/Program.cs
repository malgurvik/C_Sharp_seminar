/*Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое
каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] GetAVGInArray(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array[j, i];
        }
        avgArray[i] = result / array.GetLength(0);
    }
    return avgArray;
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

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int userM = UserInOut("Введите число строк: ");
int userN = UserInOut("Введите число столбцов: ");
int[,] uArr = Get2dArray(userM, userN);
Print2dArray(uArr);
System.Console.WriteLine();
double[] resultArray = GetAVGInArray(uArr);
PrintArray(resultArray);


// public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//     static void PrintListAvr (double [] list)
//     {
//         Console.WriteLine("The averages in columns are:");
//         foreach (double el in list)
//         {
//             Console.Write($"{el:f2}"+"\t");

//         }
//         Console.WriteLine();
//     }

//     static double [] FindAverageInColumns (int [,] matrix)
//     { 
//         double runningSum=0;
//         double [] columns = new double [matrix.GetLength(1)];
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             runningSum=0;
//             for (int i=0; i<matrix.GetLength(0);i++)
//             {
//                 runningSum=runningSum+matrix[i,j];
//             }
//             columns[j]=runningSum/matrix.GetLength(0);
//         }
//         return columns;
//     }