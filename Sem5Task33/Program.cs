//=============================================================================
// # 33 Задайте массив. Напишите программу, которая определяет, присутствует ли 
// заданное число в массиве.
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

bool FindNumber(int[] array, int number)
{
    //bool result = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            //result = true;
            return true;
        }
    }
    //return result;
    return false;
}

void PrintData(bool result, int number)
{
    if(result)
    {
        Console.WriteLine($"В данном массиве есть число {number}");
    }
    else
    {
        Console.WriteLine($"В данном массиве нет числа {number}");
    }
}

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите минимальное отрицательное число в массиве: ");
int topBorder = ReadData("Введите максимальное положительное число в массиве: ");
int number = ReadData("Введите число, которое хотите найти в массиве: ");
int[] array = FillGenerator(arrayLength, downBorder, topBorder);
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}");
bool result = FindNumber(array, number);
PrintData(result, number);