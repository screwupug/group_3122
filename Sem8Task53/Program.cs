//=======================================================================================
// # 53 Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива. 
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

void RowsChanger(int[,] array2D)
{
    int buff = 0;
     for(int i = 0; i < array2D.GetLength(1); i++)
    {
        buff = array2D[0, i];
        array2D[0, i] = array2D[array2D.GetLength(0) - 1, i];
        array2D[array2D.GetLength(0) - 1, i] = buff;
    }
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

int[] rowsColumns = ReadData("Введите кол-во строк и столбцов через запятую: ");
int[,] array2D = Array2DGenerator(rowsColumns);
Print2DArray(array2D);
RowsChanger(array2D);
Console.WriteLine();
Print2DArray(array2D);