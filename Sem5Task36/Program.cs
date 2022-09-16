//=======================================================================================
// # 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях
//=======================================================================================

int[] ArrayGenerator()
{
    Random rdn = new Random();
    int[] array = new int[100];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rdn.Next(-100, 100);

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
    return (a % 2 != 0);
}

int OddSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Test(i))
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] array = ArrayGenerator();
Console.WriteLine("Исходный массив:");
PrintArray(array);
int result = OddSum(array);
PrintResult($"Сумма чисел на нечетных позициях массива - {result}");

//=======================================================================================
// # 36* Найдите все пары в массиве и выведите пользователю
//=======================================================================================

// Сортируем массив
int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

// Ищем кол-во парных чисел в сорт массиве
int PairsCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
            i += 2;// тут перешагиваем через 2 индекса, тк нам уже известно, что тут парное число
        }
    }
    return count;
}

// Собираем парочки вместе
string Pairs(int[] array)
{
    string a = "";
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            a = a + array[i].ToString() + "/" + array[i + 1].ToString() + " ";
            i += 2;
        }
    }
    return a;
}

int[] sortedArray = BubbleSort(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(sortedArray);
int pairsCount = PairsCount(sortedArray);
Console.WriteLine($"Количество пар в массиве - {pairsCount}");
string pairs = Pairs(sortedArray);
Console.WriteLine($"Парные числа в массиве:\n{pairs}");
