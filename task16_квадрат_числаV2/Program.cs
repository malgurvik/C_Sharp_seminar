/*
16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

System.Console.WriteLine("Введите число 1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2 || userNumber2 == userNumber1 * userNumber1)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}