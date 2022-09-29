//=======================================================================================
// # 54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива. 
//=======================================================================================

// Получаем данные из строки + парсим их в массив
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

// Генерируем двумерный массив
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

// Сортируем строки в массиве методом пузырька
int[,] SortArray2D(int[,] array2D)
{
    int buff = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            for (int k = j + 1; k < array2D.GetLength(1); k++)
            {
                if (array2D[i, k] > array2D[i, j])
                {
                    buff = array2D[i, j];
                    array2D[i, j] = array2D[i, k];
                    array2D[i, k] = buff;
                }
            }
        }
    }
    return array2D;
}

int[] rowsColumns = ReadData("Введите кол-во строк и столбцов через запятую: ");
int[,] array2D = Array2DGenerator(rowsColumns);
Print2DArray(array2D);
SortArray2D(array2D);
Console.WriteLine();
Print2DArray(array2D);