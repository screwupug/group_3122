//=======================================================================================
// # 52 2 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце. 
//=======================================================================================

int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] numbersLine = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] numbers = new int[numbersLine.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = int.Parse(numbersLine[i]);
    }
    return numbers;
}

int[,] Array2DGenerator(int[] numbers)
{
    Random rdn = new Random();
    int[,] array2D = new int[numbers[0], numbers[1]];
    for (int i = 0; i < numbers[0]; i++)
    {
        for (int j = 0; j < numbers[1]; j++)
        {
            array2D[i, j] = rdn.Next(0, 100 + 1);
        }


    }
    return array2D;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }

}

double[] Average(int[,] array2D)
{
    double[] average = new double[array2D.GetLongLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            average[j] = average[j] + array2D[i, j];
        }
    }
    for(int i = 0; i < average.Length; i++)
    {
        average[i] = average[i] / (double)array2D.GetLongLength(0);
    }
    return average;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}



int[] arrayChars = ReadData("Введите кол-во строк и стобцов массива через запятую: ");
int[,] array2D = Array2DGenerator(arrayChars);
Print2DArray(array2D);
double[] average = Average(array2D);
PrintArray(average);