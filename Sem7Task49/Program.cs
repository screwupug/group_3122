//=======================================================================================
// # 49 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты.
//=======================================================================================
int ReadData(string line)
{
    Console.Write(line);
    int input = int.Parse(Console.ReadLine() ?? "0");
    return input;
}

int[,] Array2DGenerator(int countRow, int countColumn)
{
    Random rdn = new Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rdn.Next(0, 10 + 1);
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

int[,] Pow(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                array2D[i, j] = Convert.ToInt32(Math.Pow(array2D[i, j], 2));
            }
        }
    }
    return array2D;
}

int countRow = ReadData("Введите кол-во строк: ");
int countColumn = ReadData("Введите кол-во столбцов: ");
int[,] array2D = Array2DGenerator(countRow, countColumn);
Print2DArray(array2D);
array2D = Pow(array2D);
Console.WriteLine("");
Print2DArray(array2D);
