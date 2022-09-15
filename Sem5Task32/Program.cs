//=============================================================================
// # 32 Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
//=============================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[] FillGenerator(int arrayLength, int downBorder, int topBorder)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];

    // Проверка границ
    if (downBorder < topBorder)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(downBorder, topBorder + 1);
        }
    }

    return array;
}

int[] ReverseNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array[i] *= -1;
        }
        else
        {
            array[i] *= -1;
        }
    }
    return array;
}

void PrintData(int[] array)
{
    Console.WriteLine("Перевернутый массив - ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите минимальное отрицательное число в массиве: ");
int topBorder = ReadData("Введите максимальное положительное число в массиве: ");
int[] array = FillGenerator(arrayLength, downBorder, topBorder);
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}");

int[] arrayWithReverseNumbers = ReverseNumbers(array);
PrintData(arrayWithReverseNumbers);
