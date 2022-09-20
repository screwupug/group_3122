//=======================================================================================
// # 39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
// на первом месте, а первый - на последнем и т.д.)
//=======================================================================================

int[] ArrayGenerator()
{
    Random rdn = new Random();
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(1, 99);

    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

// Метод разворота с записью в новый массив
int[] SwapNewArray(int[] array)
{
    int[] swapedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        swapedArray[i] = array[array.Length - 1 - i];
    }
    return swapedArray;
}

// Метод разворота массива
int[] SwapArray(int[] array)
{
    int buff = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        buff = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = buff;
    }
    return array;
}

int[] newArray = ArrayGenerator();
PrintArray(newArray);
int[] swapedNewArray = SwapNewArray(newArray);
PrintArray(swapedNewArray);
newArray = SwapArray(newArray);
PrintArray(newArray);
