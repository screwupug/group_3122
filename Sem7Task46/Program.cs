//=======================================================================================
// # 46 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//=======================================================================================

int ReadData(string line)
{
    Console.Write(line);
    int input = int.Parse(Console.ReadLine() ?? "0");
    return input;
}

int[,] Array2DGenerator(int countRow, int countColumn, int downBorder, int topBorder)
{
    Random rdn = new Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rdn.Next(downBorder, topBorder + 1);
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

// Печать массива цветом
void Print2DArrayColored(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{array[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine("");
    }

}

int row = ReadData("Введите кол-во строк: ");
int column = ReadData("Введите кол-во столбцов: ");
int[,] array2D = Array2DGenerator(row, column, 0, 100);
Print2DArrayColored(array2D);