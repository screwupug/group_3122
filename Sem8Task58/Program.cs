//=======================================================================================
// # 58 Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц. 
//=======================================================================

// Получаем данные из консоли
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
            array2D[i, j] = rnd.Next(0, 5 + 1);
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

// Метод произведения двух матриц
int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}

int[] rowsColums1 = ReadData("Введите кол-во строк и столбцов первого массива через запятую: ");
int[] rowsColums2 = ReadData("Введите кол-во строк и столбцов второго массива через запятую: ");
int[,] matrix1 = Array2DGenerator(rowsColums1);
int[,] matrix2 = Array2DGenerator(rowsColums2);
Print2DArray(matrix1);
Console.WriteLine();
Print2DArray(matrix2);
int[,] matrix3 = DivMatrix(matrix1, matrix2);
Console.WriteLine();
Print2DArray(matrix3);