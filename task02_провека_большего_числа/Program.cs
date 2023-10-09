/*
Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> Первое число 5 меньше чем второе число 7

a = 2; b = 2 -> Введенные числа равны 2

a = -3; b = -9 -> Первое число -3 больше чем второе число -9
*/



System.Console.WriteLine("Введите число 1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
if (firstNumber < secondNumber)
{
    System.Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
if (firstNumber == secondNumber)
{
    System.Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}