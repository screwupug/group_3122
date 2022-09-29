//=======================================================================================
// # 59 Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку 
// и столбец, на пересечении которых расположен наименьший элемент массива.
//=======================================================================================

int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] inputNumber = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] rowsColumns = new int[inputNumber.Length];
    for (int i = 0; i < rowsColumns.Length; i++)
    {
        rowsColumns[i] = int.Parse(inputNumber[i]);
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
            array2D[i, j] = rnd.Next(0, 100 + 1);
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

void MinNumberFinder(int[,] array2D, ref int x, ref int y)
{
    int minNumber = array2D[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] < minNumber)
            {
                minNumber = array2D[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] RowsColumnnsDeletor(int[,] array2D, int x, int y)
{
    int k = 0;
    int l = 0;
    int[,] modifiedArray = new int[array2D.GetLength(0) - 1, array2D.GetLength(1) - 1];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (i == x)
        {

        }
        else
        {
            l = 0;
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                if (j == y)
                {

                }
                else
                {
                    modifiedArray[k, l] = array2D[i, j];
                    l++;
                }
            }
            k++;
        }


    }
    return modifiedArray;
}



int[] rowsColumns = ReadData("Введите кол-во строк и столбцов: ");
int[,] array2D = Array2DGenerator(rowsColumns);
int x = -1;
int y = -1;
MinNumberFinder(array2D, ref x, ref y);
Print2DArray(array2D);
Console.WriteLine();

int[,] modifiedArray = RowsColumnnsDeletor(array2D, x, y);
Print2DArray(modifiedArray);