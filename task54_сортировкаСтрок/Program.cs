/*
Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortRowsDescendingBuble(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int tmp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
}

void SortRowsDescendingChoice(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)               
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            int max = j;
            for (int k = j; k < matrix.GetLength(1); k++)            
            {
                if (matrix[i, max] < matrix[i, k])                                                                
                {
                    max = k;
                }
            }
            var temp = matrix[i, max];                     
            matrix[i, max] = matrix[i, j];
            matrix[i, j] = temp;
            Thread.Sleep(500);
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}



int userRow = UserEnter("Ведите количество строк: ");
int userColumn = UserEnter("Ведите количество столбцов: ");
int[,] userArray = Get2DArray(userRow, userColumn);
Print2DArray(userArray);
Console.WriteLine($"\nОтсортированный массив: ");
SortRowsDescendingBuble(userArray);
Print2DArray(userArray);
System.Console.WriteLine();
SortRowsDescendingChoice(userArray);