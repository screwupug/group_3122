//=======================================================================================
// # 48 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по 
// формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//=======================================================================================

int ReadData(string line)
{
    Console.Write(line);
    int input = int.Parse(Console.ReadLine() ?? "0");
    return input;
}

int[,] Fill2DArrMN(int m, int n)
{
    Random rdn = new Random();
    int[,] array2D = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2D[i, j] = i + j;
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

int m = ReadData("Введите кол-во строк: ");
int n = ReadData("Введите кол-во стобцов: ");
int[,] array2D = Fill2DArrMN(m, n);
Print2DArray(array2D);

