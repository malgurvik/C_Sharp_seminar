/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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

int[,] ReplaceRowsColumns(int[,] array)
{
    int[,] result = CopyArray(array);
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            tmp = result[i, j];
            result[i, j] = result[j, i];
            result[j, i] = tmp;
        }
    }
    return result;
}



int userRow = UserEnter("Ведите количество строк: ");
int userColumn = UserEnter("Ведите количество столбцов: ");
int[,] userArray = Get2DArray(userRow, userColumn);
if (userArray.GetLength(0) == userArray.GetLength(1))
{
    Print2DArray(userArray);
    System.Console.WriteLine();
    int[,] userReplace = ReplaceRowsColumns(userArray);
    Print2DArray(userReplace);
}
else System.Console.WriteLine("Количество строк и столбцов не совпадает!");
