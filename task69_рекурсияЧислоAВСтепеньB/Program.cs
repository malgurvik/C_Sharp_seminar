/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/


Console.Clear();

int UserEnter(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Stepen(int a, int b)
{
    if (b ==1)return a;
    else return a*Stepen(a,b-1);
    
}

int unumA = UserEnter("Ведите число: ");
int unumB = UserEnter("Ведите степень: ");
int result = Stepen(unumA, unumB);
System.Console.WriteLine(result);