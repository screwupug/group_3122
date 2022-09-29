//=======================================================================================
// # 55 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.  
//=======================================================================================

int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] inputNumbers = inputLine.Split(',', System.StringSplitOptions.RemoveEmptyEntries);
    int[] rowsColumns = new int[inputNumbers.Length];
    for (int i = 0; i < rowsColumns.Length; i++)
    {
        rowsColumns[i] = int.Parse(inputNumbers[i]);
    }
    return rowsColumns;
}

int[,] Array2DGenerator(int[] rowsColumns)
{
    int[,] array2D = new int[rowsColumns[0], rowsColumns[1]];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(1, 10 + 1);
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

bool TestRotate(int[,] array2D)
{
    if (array2D.GetLongLength(0) == array2D.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] RotateArray(int[,] array2D)
{
    int buff = 0;
    // 1 2 3
    // 4 5 6
    // 7 8 9
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = i + 1; j < array2D.GetLength(1); j++)
        {
            buff = array2D[i, j];
            array2D[i, j] = array2D[j, i];
            array2D[j, i] = buff;
        }
    }

    return array2D;
}

int[] inputLine = ReadData("Введите кол-во строк и столбцов через запятую: ");
int[,] array2D = Array2DGenerator(inputLine);
Print2DArray(array2D);
if (TestRotate(array2D))
{
    int[,] rotatedArray = RotateArray(array2D);
    Console.WriteLine();
    Print2DArray(rotatedArray);
}
else
{
    Console.WriteLine("В данном массиве невозможно заменить строки на столбцы.");
}