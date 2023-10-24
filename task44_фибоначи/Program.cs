/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// if (N < 1)
// {
//     Console.WriteLine("Пожалуйста, введите положительное число.");
//     return;
// }

// int first = 0;
// int second = 1;

// Console.Write("Первые " + N + " чисел Фибоначчи: ");

// if (N >= 1)
// {
//     Console.Write(first);
// }

// if (N >= 2)
// {
//     Console.Write(", " + second);
// }

// for (int i = 3; i <= N; i++)
// {
//     int next = first + second;
//     Console.Write(", " + next);
//     first = second;
//     second = next;
// }

// Console.WriteLine();

// int[] Febobachi(int number)
// {
//     int size = number;
//     if (number < 2)
//         size = 2;

//     int[] array = new int[size];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < size; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }

//     return array;
// }

// void PrintArray(int[] arrayOne)
// {
//     System.Console.Write("Число N = " + arrayOne.Length + ": ");
//     Console.ForegroundColor = ConsoleColor.DarkBlue;
//     for (int i = 0; i < arrayOne.Length; i++)
//     {
//         System.Console.Write(" " + arrayOne[i]);
//     }
//     Console.ResetColor();
// }

// int number = Prompt("Введите десятичное число: ");
// PrintArray(Febobachi(number));

void Fibonachi(int n)// 3
{
    int result = 0;
    int b = 1;
    int tmp = 0;
    if (n==0 || n==1) System.Console.WriteLine(n);
    else
    {
    for (int i = 0; i < n; i++)
    {
        result = tmp;//0 1 1
        tmp = b;//1 1 2
        b += result;//1 2 3
        System.Console.Write(result);
    }
    }
}
int userNum = UserInOut("Введите число: ");
Fibonachi(userNum);
