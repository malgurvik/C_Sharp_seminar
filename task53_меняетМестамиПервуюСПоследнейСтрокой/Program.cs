/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
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

int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j];
        }
    }
    return result;
}

int[,] ChangeRow(int[,] array)
{
    int tmp = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tmp = result[0, j];
        result[0, j] = result[array.GetLength(0) - 1, j];
        result[array.GetLength(0) - 1, j] = tmp;
    }
    return result;
}

int userRow = UserEnter("Ведите количество строк: ");
int userColumn = UserEnter("Ведите количество столбцов: ");
int[,] userArray = Get2DArray(userRow, userColumn);
Print2DArray(userArray);
System.Console.WriteLine();
int[,] userChangeRow = ChangeRow(userArray);
Print2DArray(userChangeRow);
System.Console.WriteLine();
Print2DArray(userArray);
