/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double b1 = UserInOut("Введите число b1: ");
double k1 = UserInOut("Введите число k1: ");
double b2 = UserInOut("Введите число b2: ");
double k2 = UserInOut("Введите число k2: ");



double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if (k1 == k2) System.Console.WriteLine("Прямые не пересекаются!!!");
else System.Console.WriteLine($"-> ({x}; {y})");