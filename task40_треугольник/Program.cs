/*
40. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/
//a + b > c && a + c > b && b + c > a

Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool CheckTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    return false;
}



int userA = UserInOut("Введите первое число: ");
int userB = UserInOut("Введите второе число: ");
int userC = UserInOut("Введите третье число: ");
System.Console.WriteLine(CheckTriangle(userA, userB, userC));