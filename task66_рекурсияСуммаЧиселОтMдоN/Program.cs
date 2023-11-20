/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Clear();

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumInMtoN(int num1, int num2)
{
    if (num1 > num2) return 0;
    else return num1+SumInMtoN(num1+1,num2);    
}



int userNum1 = UserEnter("Введите число M: ");
int userNum2 = UserEnter("Введите число N: ");
int userSum = SumInMtoN(userNum1, userNum2);
System.Console.WriteLine($"M = {userNum1}; N = {userNum2} -> {userSum}");