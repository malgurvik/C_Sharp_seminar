/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/


Console.Clear();

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multi = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multi.GetLength(0); i++)
    {
        for (int j = 0; j < multi.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multi[i, j] += matrix1[i, k]*matrix2[k,j];
            }
        }
    }
    return multi;
}

void CheckPossibleMultiple(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Перемножение не возможно!");
    }
    else
    {
        int[,] multi = MatrixMultiplication(matrix1, matrix2);
        Print2DArray(multi);
    }
}



int userRow1 = UserEnter("Ведите количество строк и столбцов первой матрицы: ");
int userColumn1 = userRow1;
int userRow2 = UserEnter("Ведите количество строк и столбцов второй матрицы: ");
int userColumn2 = userRow2;
int[,] matrix1 = Get2DArray(userRow1, userColumn1);
int[,] matrix2 = Get2DArray(userRow2, userColumn2);
Print2DArray(matrix1);
System.Console.WriteLine();
Print2DArray(matrix2);
System.Console.WriteLine();
CheckPossibleMultiple(matrix1, matrix2);
