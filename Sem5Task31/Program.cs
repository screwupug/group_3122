//=============================================================================
// # 31 Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.
//=============================================================================

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

int[] PositiveAndNegativeSum(int[] array)
{
    int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sums[0] += array[i];
        }

        else
        {
            sums[1] += array[i];
        }
    }
    return sums;
}

void PrintData(string line)
{
    Console.WriteLine(line);
}



int[] array = FillGenerator(12, -9, 9);
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length - 1]}");

int[] positiveAndNegativeSums = PositiveAndNegativeSum(array);
PrintData($"Сумма положительных чисел - {positiveAndNegativeSums[0]}\nСумма отрицательных чисел - {positiveAndNegativeSums[1]}");