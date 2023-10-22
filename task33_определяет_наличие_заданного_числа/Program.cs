/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
}

bool FindNumber(int[] arrFind, int num)
{
    
    for (int i = 0; i < arrFind.Length; i++)
    {
        if (arrFind[i] == num)
        {
            return true;
        }   
    }
    return false;
}

System.Console.WriteLine("Задай размер массива");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(userSize);
PrintArray(userArray);
System.Console.WriteLine(FindNumber(userArray, userNumber));


/*int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}


bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

void PrintArray(int[] arrayOne, bool a)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> ");
    if (a == true) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int num = Prompt("Проверка числа в массиве: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, findNum(array, num));*/