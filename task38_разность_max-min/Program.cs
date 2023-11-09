/*
38. Напишите программу для работы с массивом вещественных чисел.
Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:
Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/


Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        //array[i] = new Random().NextDouble(0, 10);
        array[i] = rand.Next(-10, 10) + rand.NextDouble();

    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    return FindMax(array) - FindMin(array);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(Math.Round(array[i], 2) + "\t");
    }
    System.Console.WriteLine();
}

int userSize = UserInOut("Введите размер массива: ");
System.Console.WriteLine();
double[] uArray = GetArray(userSize);
PrintArray(uArray);
double udiff = CalcDifferenceBetweenMaxMin(uArray);
System.Console.WriteLine($"Разность между максимальным и минимальным элементом = {Math.Round(udiff, 2)}");