/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

Console.Clear();

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void IntInMN(int num1, int num2)
{
    if (num2 >= num1)
    {
        System.Console.WriteLine(num1 + " ");
        IntInMN(num1+1, num2);
    }
    else
    return;
}

int unumA = UserEnter("Ведите число: ");
int unumB = UserEnter("Ведите число: ");
IntInMN(unumA, unumB);

