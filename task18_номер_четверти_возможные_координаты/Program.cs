/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();
System.Console.WriteLine("Ведите номер четверти: ");
int userQuarter = Convert.ToInt32(Console.ReadLine());
if (userQuarter == 1)
{
    System.Console.WriteLine("Все X > 0, все y > 0");
}
if (userQuarter == 2)
{
    System.Console.WriteLine("Все X < 0, все y > 0");
}
if (userQuarter == 3)
{
    System.Console.WriteLine("Все X < 0, все y < 0");
}
if (userQuarter == 4)
{
    System.Console.WriteLine("Все X > 0, все y < 0");
}