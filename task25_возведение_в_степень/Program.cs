/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// void Exponentation(int a, int b) //Exponentation(возведение в степень)
// {
//     double result = Math.Pow(a, b);
//     System.Console.WriteLine(result);
// }

void Exponentation(int a, int b) //Exponentation(возведение в степень)
{
    //double result = Math.Pow(a, b);
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    System.Console.WriteLine(result);
}

// double Exponentation(int a, int b) //Exponentation(возведение в степень)
// {
//     //double result = Math.Pow(a, b);
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }


Console.Clear();
System.Console.WriteLine("Ведите число A и B: ");
int userNumberA = int.Parse(Console.ReadLine());
int userNumberB = int.Parse(Console.ReadLine());
Exponentation(userNumberA, userNumberB);
// System.Console.WriteLine();
// double userResult = Exponentation(userNumberA, userNumberB);
// System.Console.WriteLine($"{userNumberA}, {userNumberB} -> {userResult}");
