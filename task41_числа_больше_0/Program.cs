/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

// int UserInOut(string message)
// {
//     System.Console.WriteLine(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

string UserEnter(string message)
{
    System.Console.WriteLine(message);
    string result = Convert.ToString(Console.ReadLine());
    return result;
}

int CheckPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }
    return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
}

string userInput = UserEnter("Введите числа массива через пробел: ");
var arString = userInput.Split(' ');
int[] uArray = Array.ConvertAll(arString, s => int.Parse(s));
System.Console.WriteLine();
PrintArray(uArray);
System.Console.WriteLine($" -> Количество чисел больше нуля {CheckPositiveNum(uArray)}");
