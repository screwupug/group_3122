//=======================================================================================
// # 62 Напишите программу, которая заполнит спирально массив 4 на 4.
//=======================================================================

// Получаем данные из консоли
int[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? "";
    string[] inputNumber = inputLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] rowsCols = new int[inputNumber.Length];
    for (int i = 0; i < rowsCols.Length; i++)
    {
        rowsCols[i] = int.Parse(inputNumber[i]);
    }
    return rowsCols;
}

// Метод печати массива
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

// Закручиваем спираль через повороты
int[,] SpiralGen(int[] rowsCols)
{
    int[,] array2D = new int[4,4];
    int startRow = 0;
    int endRow = array2D.GetLength(0) - 1;
    int startCol = 0;
    int endCol = array2D.GetLength(1) - 1;
    int counter = 1;

    while (startRow <= endRow && startCol <= endCol)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            array2D[startRow, i] = counter;
            counter++;
        }
        startRow++;

        for (int j = startRow; j <= endRow; j++)
        {
            array2D[j, endCol] = counter;
            counter++;
        }
        endCol--;

        for (int k = endCol; k >= startCol; k--)
        {
            array2D[endRow, k] = counter;
            counter++;
        }
        endRow--;

        for (int n = endRow; n >= startRow; n--)
        {
            array2D[n, startCol] = counter;
            counter++;
        }
        startCol++;
    }
    return array2D;
}

int[] rowsCols = ReadData("Введите кол-во строк и столбцов: ");
int[,] matrix = SpiralGen(rowsCols);
Print2DArray(matrix);