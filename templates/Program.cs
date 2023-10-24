
Console.Clear();

int UserInOut(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


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
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}


string UserEnter(string message)
{
    System.Console.WriteLine(message);
    string result = Convert.ToString(Console.ReadLine());
    return result;
}

string userInput = UserEnter("Введите числа массива через пробел: ");
var arString = userInput.Split(' ');
int[] uArray = Array.ConvertAll(arString, s => int.Parse(s));