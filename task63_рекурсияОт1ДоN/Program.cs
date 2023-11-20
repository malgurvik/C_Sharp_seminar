/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
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
        System.Console.Write(current + " ");
        IntegerN(num, current + 1);
    }
    else
        return;
}


// void IntegerN(int num, int current = 1)
// {
//     if (num < current) return;
//     else
//     {
//         System.Console.Write(current + " ");
//         IntegerN(num, current + 1);
//     }
// }
int userNum = UserEnter("Введите число: ");
IntegerN(userNum);