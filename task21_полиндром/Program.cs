/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.


14212 -> False
12821 -> True
234322 -> Число не пятизначное
                     False
*/

Console.Clear();
System.Console.WriteLine("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

// Version 1
/* 
int num1 = userNumber / 10000;
int num2 = userNumber / 1000;
int num4 = userNumber / 10;
int num5 = userNumber % 10;

if (num1 == num5 || num2 == num4)
{
    System.Console.WriteLine("True");
}
 
 else if (userNumber < 10000 || userNumber > 100000)
{
    System.Console.WriteLine("Это не пятизначное число, попробуй ещё раз.");
    System.Console.WriteLine("\t\t\t\t\t False");
}
else
{
    System.Console.WriteLine("False");
}
*/



// Version 2

int reverse = 0;
int count = 0;
for (int i = userNumber; i > 0; i /= 10)
{
    reverse = (reverse * 10) + (i % 10);
    count++;
}
if (reverse == userNumber)
{
    System.Console.WriteLine("True");
}
else if (count != 5)
{
    System.Console.WriteLine("Это не пятизначное число, попробуй ещё раз.");
    System.Console.WriteLine("\t\t\t\t\t False");
}
else System.Console.WriteLine("False");

// Version 3 для автотеста
/*int reverse = 0;
int count = 0;
for (int i = number; i > 0; i /= 10)
{
    reverse = (reverse * 10) + (i % 10);
    count++;
}
if (count != 5)
{
    System.Console.WriteLine("Число не пятизначное");
    return false;
}
else if (reverse == number)
{
    return true;
}
else return false;*/