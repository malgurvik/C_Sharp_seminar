/*
Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetIndex2DArray(int row, int column, int k)
{
    int[,] array = new int[row, column];
    int num = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = num;
            num = num + k;
        }
    }
    return array;
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

void FindElemnetInArray(int[,] array, int x, int y)
{
    if(x < array.GetLength(0) && y < array.GetLength(1))
    System.Console.WriteLine($"Такое число в массиве есть, это число {array[x, y]}");
    else
    System.Console.WriteLine("Такого числа в массиве нет!");
}
int userArrayRow = UserInOut("Введите количестов строк:");
int userArrayColumn = UserInOut("Введите количестов столбцов:");
int numberK = UserInOut("На какое число увеличить? ");
int[,] user2DIndexArray = GetIndex2DArray(userArrayRow, userArrayColumn, numberK);

Print2DArray(user2DIndexArray);
int PositionX = UserInOut("Введите строку: ");
int PositionY = UserInOut("Введите столбец: ");


FindElemnetInArray(user2DIndexArray, PositionX, PositionY);


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

//       public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
//     {
//         int[] number = { 0, -1 };
//         if (rowPosition >= 0 && rowPosition < matrix.GetLength(0) && columnPosition >= 0 && columnPosition < matrix.GetLength(1))
//         {
//             number[1] = 0;
//             number[0] = matrix[rowPosition, columnPosition];
//         }
//         return number;
//     }
//   public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//         if (results[1]==-1){Console.WriteLine("There is no such index");}
//         else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         }
//     }
