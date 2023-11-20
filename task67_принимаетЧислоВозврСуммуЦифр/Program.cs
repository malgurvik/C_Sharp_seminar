/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int IntSum(int num)
{
    if (num % 10 > 0) return num % 10 + IntSum(num / 10);
    else return 0;
}

int unum = UserEnter("Ведите число: ");
int sum = IntSum(unum);
System.Console.WriteLine(sum);