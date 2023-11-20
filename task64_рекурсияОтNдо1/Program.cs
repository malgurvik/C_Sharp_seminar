/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.Clear();

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void IntegerN(int num, int current = 1)
{
    if (num >= current)
    {
        System.Console.Write(num + " ");
        IntegerN(num - 1, current);
    }
    else
        return;
}



int userNum = UserEnter("Введите число: ");
IntegerN(userNum);