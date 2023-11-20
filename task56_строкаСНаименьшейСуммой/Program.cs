/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
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

int SumOfRow(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

void MinSumRow(int[,] array)
{
    int minSumRow = 0;
    int sumRow = SumOfRow(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tmp = SumOfRow(array, i);
        if (sumRow > tmp)
        {
            sumRow = tmp;
            minSumRow = i;
        }
    }
    Console.WriteLine($"{minSumRow+1} - строкa с наименьшей суммой элементов({sumRow}) ");
}



int userRow = UserEnter("Ведите количество строк и столбцов: ");
int userColumn = userRow;
int[,] userArray = Get2DArray(userRow, userColumn);
Print2DArray(userArray);
MinSumRow(userArray);
