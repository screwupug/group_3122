//=======================================================================================
// # 34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//=======================================================================================

int[] ArrayGenerator()
{
    Random rdn = new Random();
    int[] array = new int[30];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(100, 1000);

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

bool Test(int a)
{
    return (a % 2 == 0);
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Test(array[i]))
        {
            count++;
        }
    }
    return count;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] array = ArrayGenerator();
PrintArray(array);
int count = EvenNumbers(array);
PrintResult($"Количество четных чисел в массиве - {count}");

//=======================================================================================
// # 34* Отсортировать массив методом пузырька
//=======================================================================================

int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] % 2 == 0)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

int[] sortedArray = BubbleSort(array);
Console.WriteLine("");
Console.WriteLine("Отсортированный массив:");
PrintArray(array);