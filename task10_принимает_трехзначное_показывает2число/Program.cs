﻿/*
10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000)
{
    System.Console.WriteLine("Это не трёхзначное число!");
}
else
{
    int second = number / 10;
    int result = second % 10;
    //int result = number / 10 % 10; Не моё
    System.Console.WriteLine(result);
}