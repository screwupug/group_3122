//=======================================================================================
// # 57 Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных. 
//=======================================================================================

int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] inputNumber = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] minMax = new int[inputNumber.Length];
    for (int i = 0; i < minMax.Length; i++)
    {
        minMax[i] = int.Parse(inputNumber[i]);
    }
    return minMax;
}

int[,] Array2DGenerator(int[] minMax)
{
    int[,] array2D = new int[10, 10];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(minMax[0], minMax[1] + 1);
        }
    }
    return array2D;
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

Dictionary<int, int> Dictionary(int[,] array2D)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (dic.ContainsKey(array2D[i, j]))
            {
                dic[array2D[i, j]] = dic[array2D[i, j]] + 1;
            }
            else
            {
                dic.Add(array2D[i, j], 1);
            }
        }
    }
    return dic;
}

int[] minMax = ReadData("Введите минимальное и максимальное числа в массиве: ");
int[,] array2D = Array2DGenerator(minMax);
Print2DArray(array2D);
Dictionary<int, int> dict = Dictionary(array2D);
foreach(KeyValuePair<int, int> kvp in dict)
{
    Console.WriteLine($"Число {kvp.Key} - {kvp.Value} - повторений");
}