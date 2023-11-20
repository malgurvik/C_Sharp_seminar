﻿/*
61. Вывести первые N строк треугольника Паскаля. Сделать вывод
в виде равнобедренного треугольника
*/
Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, row];
const int cellWidth = 3;
void FillTriangle(int[,] matrix, int row)
{
    for (int i = 0; i < row; i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
        }
    }
}
void PrintTriangle(int[,] matrix, int row)
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (matrix[i, j] != 0)
                Console.Write($"{matrix[i, j],cellWidth}");

            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
FillTriangle(matrix, row);
PrintTriangle(matrix, row);