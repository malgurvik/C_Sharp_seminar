/*
34. Напишите программу, которая подсчитывает количество четных элементов в массиве 
целых положительных трехзначных чисел и выводит результат на экран.
Аргументы, передаваемые в метод/функцию:
'124, 378, 593, 821, 456'
Массив:
124     378     593     821     456 
Количество четных элементов: 3
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}


int userSize = UserInOut("Введите размер массива: ");
int[] uArray = GetArray(userSize);
int countArray = CountEvenElements(uArray);
PrintArray(uArray);
System.Console.WriteLine($"Количество четных элементов: {countArray}");