//=======================================================================================
// # 45 Напишите программу, которая будет создавать копию заданного одномерного массива 
// с помощью поэлементного копирования.
//=======================================================================================

int[] ReadArrayOptions(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] stringArray = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[stringArray.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(stringArray[i]);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}, ");
    for(int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int[] array = ReadArrayOptions("Введите массив чисел через запятую: ");
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);