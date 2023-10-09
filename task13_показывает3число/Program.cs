/*
13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>100 && number<1000)
{
    int third = number % 10;
    System.Console.WriteLine(third);
}

else if (number>999)
{
    while (number>=1000)
    {
        number = number / 10; 
    }
    int third2 = number % 10;
    System.Console.WriteLine(third2);
}
else if (number<100)
{
    System.Console.WriteLine("Третьей цифры нет(");
}
