/*
59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
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


(int, int) FindMinIndex(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteMinColumnRow(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int x = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        }
        int y = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == column) continue;
            result[x, y] = array[i, j];
            y++;
        }
        x++;
    }
    return result;
}





int userRow = UserEnter("Ведите количество строк: ");
int userColumn = UserEnter("Ведите количество столбцов: ");
int[,] userArray = Get2DArray(userRow, userColumn);
Print2DArray(userArray);
(int minRow, int minColumn) = FindMinIndex(userArray);
int[,] newArray = DeleteMinColumnRow(userArray, minRow, minColumn);
System.Console.WriteLine();
Print2DArray(newArray);
