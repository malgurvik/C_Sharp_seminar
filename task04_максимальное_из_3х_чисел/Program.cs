/*
Внутри класса Answer напишите метод FindMax, который принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/



System.Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

/*int max;
    if (a > b)
      max = a;
    else if (b > c)
      max = b;
    else
      max = c;
    return max;*/

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}


System.Console.WriteLine("max = " + max);