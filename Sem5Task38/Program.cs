//=======================================================================================
// # 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
//=======================================================================================

double[] ArrayGenerator()
{
    Random rdn = new Random();
    double[] array = new double[20];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =Math.Round((rdn.Next(-100, 1000)* 0.01), 2);

    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double CalculateDiff(double min, double max)
{
    double result = max - min;
    return result;
}

double[] array = ArrayGenerator();
PrintArray(array);
double min = MinNumber(array);
Console.WriteLine($"Минимальное число в массиве - {min}");
double max = MaxNumber(array);
Console.WriteLine($"Максимальное число в массиве - {max}");
double result = CalculateDiff(min, max);
Console.WriteLine($"Разница между максимальным и минимальным числами в массиве - {Math.Round(result, 2)}");

// Можно и одним методом все записать)

double CalculateDiffAlt(double[] array)
{
    double min = array[0];
    double max = array[0];
    double result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    result = max - min;
    return result;
}

double resultAlt = CalculateDiffAlt(array);
Console.WriteLine($"Алтернативный метод подсчета. Результат - {Math.Round(resultAlt, 2)}");

//=======================================================================================
// # 38 Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
//=======================================================================================

// Метод вставки
double InsertionSort(double[] array)
{
     double[] sortedArray = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && sortedArray[j - 1] > array[i])
                {
                    sortedArray[j] = sortedArray[j - 1];
                    j--;
                }
                sortedArray[j] = array[i];
            }
            double result = sortedArray[0] - sortedArray[array.Length - 1];
            return result;
}

// Я так и не понял как реализовать метод подсчета с таким массивом
// поэтому использовал метод пузырьком

double BubbleSort(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                double temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    double result = array[0] - array[array.Length - 1];
    return result;
}

DateTime d1 = DateTime.Now;
double resultInsertion = InsertionSort(array);
Console.WriteLine(DateTime.Now - d1);
Console.WriteLine($"Метод сортировки вставкой - {Math.Round(resultInsertion, 2)}");
DateTime d2 = DateTime.Now;
double resultBubble = BubbleSort(array);
Console.WriteLine(DateTime.Now - d2);
Console.WriteLine($"Метод сортировки пузырьком - {Math.Round(resultBubble, 2)}");
Console.WriteLine("Метод сортировки пузырьком почти всегда быстрее");