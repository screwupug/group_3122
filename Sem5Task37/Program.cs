//=======================================================================================
// # 35 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//=======================================================================================

int[] ArrayGenerator()
{
    Random rdn = new Random();
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(0, 21);

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

int[] PairsPow(int[] array)
{
    int[] powArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        powArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return powArray;
}

void PrintPowArray(int[] powArray)
{
    Console.Write("[" + powArray[0] + ", ");
    for (int i = 1; i < powArray.Length - 1; i++)
    {
        Console.Write($"{powArray[i]}, ");
    }
    Console.WriteLine($"{powArray[powArray.Length - 1]}]");
}

int[] array = ArrayGenerator();
PrintArray(array);
int[] newArray = PairsPow(array);
PrintPowArray(newArray);